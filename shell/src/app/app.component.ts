import { Component, HostListener, AfterViewInit, ViewChild } from '@angular/core';
import { MatSidenav } from '@angular/material';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements AfterViewInit {

  private sideBySideWidth: number = 992;
  private isSideBySide: boolean = false;

  get isOpened() { return this.isSideBySide; }
  get mode() { return this.isSideBySide ? 'side' : 'over'; }

  @ViewChild(MatSidenav)
  sidenav: MatSidenav;

  @HostListener('window:resize', ['$event.target.innerWidth'])
  onResize(width) {
    this.isSideBySide = width > this.sideBySideWidth;
  }

  ngAfterViewInit(): void {
    this.onResize(window.innerWidth);
  }
  
  tocEntryChanged(url) {
    if(!this.isSideBySide) {
      this.sidenav.close();
    }
  }
}
