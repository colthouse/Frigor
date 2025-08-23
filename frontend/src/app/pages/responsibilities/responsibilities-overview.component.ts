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
  ],
templateUrl: './responsibilities-overview.component.html',
  styleUrl: './responsibilities-overview.component.scss',
})
export class ResponsibilitiesOverviewComponent {
  userCtrl = new FormControl('');
  displayedColumns = ['title', 'owner', 'streak', 'status', 'created', 'tags'];
}
