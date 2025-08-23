import { Component } from '@angular/core';
import { Dialog } from '@angular/cdk/dialog';
import { MatDialog, MatDialogModule, MatDialogRef } from '@angular/material/dialog';
import {MAT_DIALOG_DATA} from '@angular/material';

@Component({
  selector: 'app-popup',
  standalone: true,
  imports: [MatDialogModule,
    MatDialogRefModule
  ],
  templateUrl: './popup.component.html',
  styleUrl: './popup.component.scss'
})
export class PopupComponent {
  constructor(private dialogRef: MatDialogRef<PopupComponent>) {}
closeDialog() {
  this.dialogRef.close();
}
}
