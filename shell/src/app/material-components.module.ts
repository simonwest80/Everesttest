import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
   MatSidenavModule,
   MatToolbarModule,
   MatButtonModule,
   MatToolbarRow ,
   MatIconModule,
   MatSnackBarModule
  } from '@angular/material';

@NgModule({
  exports: [MatSidenavModule, MatIconModule, MatButtonModule, MatToolbarModule, MatSnackBarModule]
})
export class MaterialComponentsModule { }
