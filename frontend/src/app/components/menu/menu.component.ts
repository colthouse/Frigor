import { Component } from '@angular/core';
import {MatToolbar} from '@angular/material/toolbar';
import {MatAnchor, MatIconButton} from '@angular/material/button';
import {RouterLink} from '@angular/router';
import {MatIcon} from '@angular/material/icon';

@Component({
  selector: 'app-menu',
  standalone: true,
  templateUrl: './menu.component.html',
  imports: [
    MatToolbar,
    MatAnchor,
    RouterLink,
    MatIconButton,
    MatIcon
  ],
  styleUrl: './menu.component.scss'
})
export class MenuComponent {

}
