import { Component } from '@angular/core';
import { MatButtonToggle } from "@angular/material/button-toggle";
import { MatCard } from '@angular/material/card';

@Component({
  selector: 'app-review',
  standalone: true,
  imports: [MatButtonToggle,
    MatCard
  ],
  templateUrl: './review.component.html',
  styleUrl: './review.component.scss'
})
export class ReviewComponent {

}
