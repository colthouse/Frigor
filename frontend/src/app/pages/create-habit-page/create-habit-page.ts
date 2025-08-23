import { Component, signal } from '@angular/core';
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
    MatButton,
    MatButtonToggleModule
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
}

export class ButtonToggleModeExample {
  hideMultipleSelectionIndicator = signal(false);

  toggleMultipleSelectionIndicator() {
    this.hideMultipleSelectionIndicator.update(value => !value);
  }
}
