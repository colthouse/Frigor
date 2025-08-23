import { Component } from '@angular/core';
import { HabitComponent } from "../../components/habit/habit.component";

@Component({
  selector: 'app-gabi-space',
  standalone  : true,
  imports: [HabitComponent],
  templateUrl: './gabi-space.html',
  styleUrl: './gabi-space.scss'
})
export class GabiSpace {
  
}
