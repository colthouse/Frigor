import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HabitComponent } from "./components/habit/habit.component";

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  imports: [
    RouterOutlet
  ],
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'frigor';
}
