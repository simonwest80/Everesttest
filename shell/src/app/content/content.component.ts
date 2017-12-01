import { Component, OnInit, OnDestroy, HostListener, ElementRef, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { LocationService } from '../location.service';
import { Subscription } from 'rxjs/Subscription';
import { AppConfig } from '../app-config';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.scss']
})
export class ContentComponent implements OnInit, OnDestroy {
  data: string = "Loading...";
  subLocation: Subscription;
  appHrefs: string[];
  offsets : Map<string, number> = new Map<string, number>();
  curHref: string = null;

  constructor(private _http: HttpClient,
              private _svcLocation: LocationService,
              private  elementRef: ElementRef,
              private conf: AppConfig) { 

                var loBaseHref = conf.BaseUrl.toLowerCase();
                this.appHrefs = [loBaseHref, /*w/o traling slash*/ loBaseHref.slice(0,-1), loBaseHref + 'index.html'];
              }

  @HostListener('click', ['$event.target', '$event.button', '$event.ctrlKey', '$event.metaKey'])
  onClick(eventTarget: HTMLElement, button: number, ctrlKey: boolean, metaKey: boolean): boolean {

    var href = '';
    if (eventTarget instanceof HTMLAnchorElement || eventTarget instanceof HTMLAreaElement) {
      href = eventTarget.getAttribute('href');
    } else if(eventTarget.parentElement instanceof HTMLAnchorElement) {
      href = eventTarget.parentElement.getAttribute('href');
    }

    if(href != '' && !href.startsWith('javascript:') && !href.startsWith('#')) {
        //fix relative links
        if(href[0] != '/') {
          var path = location.pathname;
          if(path.endsWith('/'))
            href = path + href;
          else if (path.endsWith('.html'))
            href = path.substring(0, path.lastIndexOf('/') + 1) + href;
          else
            href = path + '/' + href;
        }
        this._svcLocation.setLocation(href);
        return false;
    }
    return true;
    
  }

  ngOnInit() {
    this.subLocation = this._svcLocation.Location$.subscribe( href => { this.loadContent(href); });
  }

  ngOnDestroy(): void {
    this.subLocation.unsubscribe();
  }

  loadContent(href:string) {

    //prevent loading root index.html since it is the angular app
    if(this.isAppUrl(href)) {
      this._svcLocation.setLocation(this.conf.WelcomeUrl);
      return;
    }

    this._http.get(href, {responseType: 'text'})
    .toPromise()
    .then(html => {
      if(this.curHref != null) {
        this.offsets.set(this.curHref, this.elementRef.nativeElement.parentElement.scrollTop);
      }
      this.elementRef.nativeElement.innerHTML = html;
      this.elementRef.nativeElement.parentElement.scrollTop = this.offsets.get(href.toLowerCase()) || 0;
      this.runScripts();
      this.curHref = href;
    })
    .catch(err => {
      console.error(err);
      if(href != this.conf.NotFoundUrl)
        this.loadContent(this.conf.NotFoundUrl);
      else
        this.elementRef.nativeElement.innerHTML = "Connectivity Error";
    });
  }

  private isAppUrl(href:string) : boolean {
    return this.appHrefs.indexOf(href.toLowerCase()) > -1
  }

  private handleError(error: any): Promise<any> {
    console.error('Failed to load content', error); 
    return Promise.reject(error.message || error);
  } 

  runScripts(): void {
    //const scripts = <HTMLScriptElement[]>this.elementRef.nativeElement.querySelectorAll('script:not([data-sys=1])');
    const scripts = <HTMLScriptElement[]>this.elementRef.nativeElement.querySelectorAll('script');
    const scriptsInitialLength = scripts.length;
    for (let i = 0; i < scriptsInitialLength; i++) {
        const script = scripts[i];

        if(script.getAttribute("data-sys") == "1") //skip sys scripts
          continue;

        const scriptCopy = <HTMLScriptElement>document.createElement('script');
        scriptCopy.type = script.type ? script.type : 'text/javascript';
        if (script.innerHTML) {
            scriptCopy.innerHTML = script.innerHTML;
        } else if (script.src) {
            scriptCopy.src = script.src;
        }
        scriptCopy.async = false;
        script.parentNode.replaceChild(scriptCopy, script);
    }
  }
}
