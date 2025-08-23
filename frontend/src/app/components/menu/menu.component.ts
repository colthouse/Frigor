import { Component } from '@angular/core';
import {MatToolbar} from '@angular/material/toolbar';
import {MatAnchor, MatIconButton} from '@angular/material/button';
import {RouterLink, RouterOutlet} from '@angular/router';
import {MatIcon} from '@angular/material/icon';
import {MatSidenav, MatSidenavContainer, MatSidenavContent} from '@angular/material/sidenav';
import {MatListItem, MatNavList} from '@angular/material/list';

@Component({
  selector: 'app-menu',
  standalone: true,
  templateUrl: './menu.component.html',
  imports: [
    MatToolbar,
    MatAnchor,
    RouterLink,
    MatIconButton,
    MatIcon,
    MatSidenavContent,
    MatSidenav,
    MatSidenavContainer,
    RouterOutlet,
    MatNavList,
    MatListItem
  ],
  styleUrl: './menu.component.scss'
})
export class MenuComponent {

}
