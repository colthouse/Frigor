import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';  // Needed for browser apps
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'; // Needed for Angular Material animations
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { CreateHabitPage } from './pages/create-habit-page/create-habit-page';
import { GabiSpace } from './pages/gabi-space/gabi-space';

// Angular Material modules
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatCardModule } from '@angular/material/card';
import { MatRadioModule } from '@angular/material/radio';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatButtonToggleModule } from '@angular/material/button-toggle';

import { ReactiveFormsModule } from '@angular/forms';
import {routes} from './app.routes';
import {HabitComponent} from './components/habit/habit.component';

@NgModule({
  declarations: [
    AppComponent,
    GabiSpace,
    HabitComponent

  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    RouterModule.forRoot(routes),  // Import RouterModule with your routes
    ReactiveFormsModule,
    // Angular Material modules
    MatFormFieldModule,
    MatCardModule,
    MatRadioModule,
    MatDatepickerModule,
    MatCheckboxModule,
    MatInputModule,
    MatButtonModule,
    MatButtonToggleModule,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
