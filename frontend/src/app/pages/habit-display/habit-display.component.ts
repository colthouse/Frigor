import {Component, OnInit} from '@angular/core';
import {HabitModel} from '../../api/models/habit.model';
import {HttpClient} from '@angular/common/http';
import {HabitApi} from '../../api/services/habit.api';

@Component({
  selector: 'app-habit-display',
  standalone: false,
  templateUrl: './habit-display.component.html',
  styleUrl: './habit-display.component.scss'
})
export class HabitDisplayComponent implements OnInit {
  protected habits: HabitModel[] = [];
  constructor(private habitApi: HabitApi) { }
  ngOnInit(): void {
    this.habitApi.getHabits(localStorage.getItem('uuid')!).subscribe(h => {
      this.habits = h
      console.log(h);
    }
    )
  }

}
