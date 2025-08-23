import { Component } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { MenuComponent } from '../components/menu/menu.component';
import { MatIcon } from '@angular/material/icon';
import { MatButtonModule } from "@angular/material/button";
import { RouterLink } from '@angular/router';
@Component({
  selector: 'app-welcome',
  standalone: true,
  imports: [
    MatCardModule,
    MenuComponent,
    MatIcon,
    MatButtonModule,
    RouterLink
],
  templateUrl: './welcome.component.html',
  styleUrl: './welcome.component.scss'
})
export class WelcomeComponent {

}
