import { Location } from '@angular/common';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { TocEntry } from './toc-entry';
import { AppConfig } from '../app-config';

@Injectable()
export class TocService {

  tocUrl: string;

  constructor(private http: HttpClient, 
              private loc: Location,
              private conf:AppConfig) {
  }

  getToc(): Promise<TocEntry> {
    return this.http.get<TocEntry>(this.conf.TocUrl)
    .toPromise()
    .catch(this.handleError); 
  }

  private handleError(error: any): Promise<any> {
    console.error('Failed to load TOC', error); 
    return Promise.reject(error.message || error);
  } 

}

