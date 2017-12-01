import { Injectable, OnInit, OnDestroy } from '@angular/core';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import { Location } from '@angular/common';
import { Subscription } from 'rxjs/Subscription';

@Injectable()
export class LocationService implements OnDestroy {

  public Location$: BehaviorSubject<string>;

  private _subLocation: Subscription;

  constructor(private _svcLocation: Location) { 
    
    this.Location$ = new BehaviorSubject<string>(this._svcLocation.path());

    this._subLocation = this._svcLocation.subscribe( 
      state => { this.Location$.next(state.url); },
      e     => {console.error('location exception', e);},
      ()    => {console.log('location on return');},
    ) as Subscription;

  }

  ngOnDestroy(): void {
    this._subLocation.unsubscribe();
  }

  getLocation(): string {
    return this.Location$.getValue();
  }

  setLocation(href:string) {
    this._svcLocation.go(href);
    this.Location$.next(href);
  }
}
