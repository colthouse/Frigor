import { Component, signal, inject } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { MatRadioModule } from '@angular/material/radio';
import { FormControl, FormGroup, ReactiveFormsModule} from '@angular/forms';
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {provideNativeDateAdapter} from '@angular/material/core';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButton } from "@angular/material/button";
import {MatButtonToggleModule} from '@angular/material/button-toggle';
import {ChangeDetectionStrategy} from '@angular/core';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';
import {MatSnackBar} from '@angular/material/snack-bar';

@Component({
  selector: 'app-create-habit-page',
  imports: [
    MatFormFieldModule,
    MatCardModule,
    MatRadioModule,
    ReactiveFormsModule,
    MatDatepickerModule,
    MatCheckboxModule,
    MatInputModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatIconModule
],
  providers: [provideNativeDateAdapter()],
  templateUrl: './create-habit-page.html',
  styleUrl: './create-habit-page.scss',
  standalone: true
})
export class CreateHabitPage {
  myForm = new FormGroup({
    name: new FormControl(''),
    description: new FormControl(''),
    date: new FormControl('')
  });

  private _snackBar = inject(MatSnackBar);

  displayDateTriggerInfo(): void {
    this._snackBar.open("Set a Date when your habit will be triggered. This should be the date on which you want to do it.",
      'Close',
    {
      duration: 10000, // 👈 10s = 10000 ms
    }
    );
  }

  displayHabitStackInfo(): void {
    this._snackBar.open("Set this habit to trigger once you've completed another habit. This process is called habit stacking.",
      'Close',
    {
      duration: 10000, // 👈 10s = 10000 ms
    });
  }
}



