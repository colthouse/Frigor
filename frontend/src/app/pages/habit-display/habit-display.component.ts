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
import { MatCard } from '@angular/material/card';
import { RouterLink } from '@angular/router';

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
    MatIconButton,
    MatCard,
    RouterLink
  ],
  styleUrl: './habit-display.component.scss'
})
export class HabitDisplayComponent implements OnInit {
  protected habits: HabitModel[] = [];
  constructor(private habitApi: HabitApi) { }
  ngOnInit(): void {
    this.habitApi.getHabits(localStorage.getItem('uuid')!).subscribe(h => {
      this.habits = h
    }
    )
  }

  onDelete(uuid: string) {
    this.habitApi.deleteHabit(uuid).subscribe(() =>
      this.habitApi.getHabits(localStorage.getItem('uuid')!).subscribe(h => {
          this.habits = h
        }
      )
    );
  }

  onAchieved(uuid: string, checked: boolean) {
    this.habitApi.habitAchieved(uuid, checked).subscribe(h => {})
  }

  isAchieved(habit: HabitModel):boolean {
    let occ = habit.occurrences.find(occurrence => {
      const now = new Date();
      const occDate =new Date(occurrence.date);
      return (
        occDate.getFullYear() === now.getFullYear() &&
        occDate.getMonth() === now.getMonth() &&
        occDate.getDate() === now.getDate()
      );
    })

    if (occ){
      return occ.isAchieved
    }
    return false
  }
}
