import { Component, OnInit, ViewEncapsulation, OnDestroy, EventEmitter, Output } from '@angular/core';

import { TocService } from './toc.service';
import { LocationService } from '../location.service';
import { Subscription } from 'rxjs/Subscription';


import 'gijgo/modular/js/core.js';
import 'gijgo/modular/js/tree.js';
declare var jQuery: any;

@Component({
  selector: 'app-toc',
  templateUrl: './toc.component.html',
  styleUrls: ['./toc.component.scss'],
  encapsulation: ViewEncapsulation.None
})
 export class TocComponent implements OnInit, OnDestroy {

  tree: any;
  subLocation: Subscription;
  isInCallback: boolean = false;
  @Output() onEntryChanged: EventEmitter<string> = new EventEmitter<string>();
  
  constructor(private _svcToc: TocService, 
              private _svcLocation: LocationService ) { }

  selectTocEntry(url:string) {
    
    this.tree.unselectAll();
    
    var node = this.tree.getNodeById(url);
    if(node == undefined) {
      url += '/index.html';
    }
    //second attempt - index.html is removed from the url (todo: research why)
    node = this.tree.getNodeById(url);
    if(node == undefined)
      return;

    var ancestors = jQuery(node).parents();
    for(var i=0; i < ancestors.length-1; i++) {
        var tagName = jQuery(ancestors[i]).prop("tagName");
        if(tagName == "LI") {
            this.tree.expand(jQuery(ancestors[i]));
        } else if(tagName == "DIV") {
            break;
        }
    }
    var data = this.tree.data();
    this.isInCallback = true;
    this.tree.select(node);
    this.tree.expand(node);
    this.isInCallback = false;

    ////make sure node is visible 
//    jQuery(node)[0].scrollIntoView();
  }

  ngOnInit() {

    this._svcToc.getToc().then( tocData => {
      
      var url = this._svcLocation.getLocation();

      this.tree = jQuery('#tree').tree({
        primaryKey: 'url',
        selectionType: 'single',
        cascadeSelection: false,
        dataSource: tocData,
        style: { 
          active: 'gj-list-md-active-ex' 
        },
        indentation: 14,
        dataBound: e => setTimeout( () => { 
          this.selectTocEntry(url);
          this.subLocation = this._svcLocation.Location$.subscribe(href => { this.selectTocEntry(href); });          
        }, 10)
      });
   
      this.tree.on('select', (e, node, id) => {
        if(!this.isInCallback) {
          this._svcLocation.setLocation(id);
          this.onEntryChanged.next(id);
        }
        return true;
      });
    });
  }

  ngOnDestroy(): void {
    this.subLocation.unsubscribe();
  }

}
