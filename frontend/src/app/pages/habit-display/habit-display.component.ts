import {Component} from '@angular/core';
import {HabitModel} from '../../api/models/habit.model';

@Component({
  selector: 'app-habit-display',
  standalone: false,
  templateUrl: './habit-display.component.html',
  styleUrl: './habit-display.component.scss'
})
export class HabitDisplayComponent {
  habits: HabitModel[] = [
    {
      Name: 'Situps',
      Uuid: "",
      Description: "",
      Trigger: null!
    },

    {
      Name: 'planks',
      Uuid: "",
      Description: "",
      Trigger: null!
    }
  ];

}
