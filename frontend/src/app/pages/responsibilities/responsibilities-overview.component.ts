// src/app/pages/godfather-overview/godfather-overview.component.ts
import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormControl } from '@angular/forms';

// Angular Material imports
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { MatOptionModule } from '@angular/material/core';
import { MatIconModule } from '@angular/material/icon';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MatTableModule } from '@angular/material/table';
import { MatChipsModule } from '@angular/material/chips';
import { MenuComponent } from '../../components/menu/menu.component';
import { HabitModel } from '../../api/models/habit.model';
import { HabitApi } from '../../api/services/habit.api';
import { MatCheckbox } from '@angular/material/checkbox';
import { MatListItem, MatNavList } from '@angular/material/list';

@Component({
  selector: 'app-responsibilities-overview',
  standalone: true,
    imports: [
    CommonModule,
    ReactiveFormsModule,
    // Material
    MatToolbarModule,
    MatCardModule,
    MatFormFieldModule,
    MatInputModule,
    MatAutocompleteModule,
    MatOptionModule,
    MatIconModule,
    MatProgressBarModule,
    MatTableModule,
    MatChipsModule,
    MenuComponent,
    MatCheckbox,
    MatNavList,
    MatListItem
  ],
templateUrl: './responsibilities-overview.component.html',
  styleUrl: './responsibilities-overview.component.scss',
})
export class ResponsibilitiesOverviewComponent {
  protected habits: HabitModel[] = [];
  constructor(private habitApi: HabitApi) { }

  ngOnInit(): void {
    this.habitApi.getGodparentHabits().subscribe(h => {
      this.habits = h;
      console.log(h+"yeet");
    }

    )
  } 
}
