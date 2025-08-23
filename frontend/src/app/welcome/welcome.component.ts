import { Component } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { MenuComponent } from '../components/menu/menu.component';
import { MatIcon } from '@angular/material/icon';
@Component({
  selector: 'app-welcome',
  standalone: true,
  imports: [
    MatCardModule,
    MenuComponent,
    MatIcon
  ],
  templateUrl: './welcome.component.html',
  styleUrl: './welcome.component.scss'
})
export class WelcomeComponent {

}
