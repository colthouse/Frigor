import {Component, OnInit} from '@angular/core';
import {HabitModel} from '../../api/models/habit.model';
import {HabitApi} from '../../api/services/habit.api';
import {MenuComponent} from '../../components/menu/menu.component';
import {MatCheckbox} from '@angular/material/checkbox';
import {MatIcon} from '@angular/material/icon';
import {MatListItem, MatNavList} from '@angular/material/list';
import {MatMenu, MatMenuItem, MatMenuTrigger} from '@angular/material/menu';
import {NgForOf} from '@angular/common';
import {MatIconButton} from '@angular/material/button';

@Component({
  selector: 'app-habit-display',
  standalone: true,
  templateUrl: './habit-display.component.html',
  imports: [
    MenuComponent,
    MatCheckbox,
    MatIcon,
    MatNavList,
    MatIcon,
    MatListItem,
    MatIcon,
    MatMenu,
    MatMenuTrigger,
    MatMenuItem,
    NgForOf,
    MatIconButton
  ],
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
