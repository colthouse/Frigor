import { Component, Input } from '@angular/core';
import {MatCheckbox, MatCheckboxModule} from '@angular/material/checkbox';
import {MenuComponent} from '../menu/menu.component';
import {MatIcon} from '@angular/material/icon';

@Component({
  selector: 'app-habit',
  standalone: true,
  templateUrl: './habit.component.html',
  imports: [
    MenuComponent,
    MatCheckbox,
    MatIcon
  ],
  styleUrl: './habit.component.scss'
})
export class HabitComponent {
  @Input()
  habitName: string | undefined;
  habitDescription: string | undefined;
}
