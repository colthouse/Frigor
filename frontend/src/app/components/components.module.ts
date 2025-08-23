import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MenuComponent} from './menu/menu.component';
import {MatToolbar} from '@angular/material/toolbar';
import {MatMenu, MatMenuItem, MatMenuTrigger} from '@angular/material/menu';
import {MatAnchor, MatButton, MatIconButton} from '@angular/material/button';
import {MatIcon} from '@angular/material/icon';
import {RouterLink} from '@angular/router';



@NgModule({
  declarations: [
    MenuComponent
  ],
  imports: [
    CommonModule,
    MatToolbar,
    MatMenu,
    MatMenuItem,
    MatButton,
    MatMenuTrigger,
    MatIcon,
    MatAnchor,
    RouterLink,
    MatIconButton
  ],
  exports: [MenuComponent]
})
export class ComponentsModule { }
