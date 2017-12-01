import { BrowserModule } from '@angular/platform-browser';
import { NgModule, InjectionToken } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';
import { MaterialComponentsModule } from './material-components.module' 

import { AppComponent } from './app.component';
import { TocComponent } from './toc/toc.component';
import { TocService } from './toc/toc.service';
import { ContentComponent } from './content/content.component';
import { LocationService } from './location.service';
import { Location, LocationStrategy, PathLocationStrategy } from '@angular/common';
import { SafeHtmlPipe } from './safe-html.pipe';
import { RunScriptsDirective } from './run-scripts.directive';
import { AppConfig } from './app-config';


export function appConfigFactory() : AppConfig { return window['EV_HELP_CONFIG']; }


@NgModule({
  declarations: [
    AppComponent,
    TocComponent,
    ContentComponent,
    SafeHtmlPipe,
    RunScriptsDirective
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MaterialComponentsModule,
    HttpClientModule
  ],
  providers: [
    TocService, 
    LocationService,
    Location, 
    {provide: LocationStrategy, useClass: PathLocationStrategy},
    {provide: AppConfig, useFactory: appConfigFactory },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }