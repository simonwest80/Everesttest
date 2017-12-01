import { Directive, ElementRef, OnInit, Input } from '@angular/core';

@Directive({ selector: '[appRunScripts]' })
export class RunScriptsDirective implements OnInit {
    
  @Input('appRunScripts')
  selector: string = 'script';

  constructor(private elementRef: ElementRef) {
    console.log('run scripts constructor');
   }

  ngOnInit(): void {
      console.log('run scripts init');
      setTimeout(() => { // wait for DOM rendering
          this.reinsertScripts();
      }, 2000);
  }

  reinsertScripts(): void {
      const scripts = <HTMLScriptElement[]>this.elementRef.nativeElement.getElementsByTagName(this.selector);
      console.log(`number of scripts according '${this.selector}' found: ${scripts.length}`);
      const scriptsInitialLength = scripts.length;
      for (let i = 0; i < scriptsInitialLength; i++) {
          const script = scripts[i];
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