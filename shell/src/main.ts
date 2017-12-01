import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';
import { AppConfig } from './app/app-config';
import { environment } from './environments/environment';

import 'hammerjs';

if (environment.production) {
  enableProdMode();
}

platformBrowserDynamic().bootstrapModule(AppModule).catch(err => console.log(err));

/*export function main(appSettings: any) {   
  platformBrowserDynamic([{ provide: AppConfig, useValue: appSettings }]).bootstrapModule(AppModule).catch(err => console.log(err));
}*/