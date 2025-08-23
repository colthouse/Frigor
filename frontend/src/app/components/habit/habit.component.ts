import { Component, Input } from '@angular/core';
import {MatCheckboxModule} from '@angular/material/checkbox';

@Component({
  selector: 'app-habit',
  standalone: false,
  templateUrl: './habit.component.html',
  styleUrl: './habit.component.scss'
})
export class HabitComponent {
  @Input()
  placeholder: string | undefined;
}
