import { NgModule, provideZoneChangeDetection } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';  // Needed for browser apps
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'; // Needed for Angular Material animations
import { provideRouter, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { CreateHabitPage } from './pages/create-habit-page/create-habit-page';

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
import { HabitDisplayComponent } from './pages/habit-display/habit-display.component';
import { MatIcon } from "@angular/material/icon";
import { LoginPage } from './pages/login/login.page';
import { MatIconModule } from '@angular/material/icon';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { provideHttpClient } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    HabitComponent,
    HabitDisplayComponent,
    LoginPage
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    RouterModule.forRoot(routes), // Import RouterModule with your routes
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
    MatIconModule
],
  bootstrap: [AppComponent],
  providers: [provideZoneChangeDetection({ eventCoalescing: true }), provideRouter(routes), provideAnimationsAsync(), provideHttpClient()]
})
export class AppModule { }
