import { Component } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { MatCardModule } from '@angular/material/card';

import { AppComponent } from './app.component';
import { CardPopupComponent } from './card-popup/card-popup.component';

@Component({
  selector: 'app-card-popup',
  standalone: true,
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatDialogModule,
    MatCardModule
  ],
  templateUrl: './card-popup.component.html',
  styleUrl: './card-popup.component.scss'
})
export class CardPopupComponent {
  constructor(public dialog: MatDialog) {}

  openCard() {
    this.dialog.open(CardPopupComponent, {
      width: '300px'  // adjust size
}
