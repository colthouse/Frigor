import { Component } from '@angular/core';
import { FormControl, ReactiveFormsModule } from '@angular/forms';
import { UserApi } from '../../api/services/user.api';
import {MatFormField, MatFormFieldModule, MatLabel} from "@angular/material/form-field";
import {MatInput, MatInputModule} from "@angular/material/input";
import {MatButton, MatButtonModule} from '@angular/material/button';
import {MatIcon, MatIconModule} from '@angular/material/icon';
import {Router} from '@angular/router';
import { UserHelper } from '../../helpers/user.helper';

@Component({
  selector: 'login-page',
  standalone: true,
  templateUrl: './login.page.html',
  imports: [
    MatFormField,
    MatLabel,
    ReactiveFormsModule,
    MatIcon,
    MatButton,
    MatInput
  ],
  styleUrl: './login.page.scss'
})
export class LoginPage {
  usernameInput = new FormControl('');


  constructor(private _userApi: UserApi, private router: Router) {}

  submit() {
    let username: string | null = this.usernameInput.value;
    if (username == null || username === "") return;

    this._userApi.loadOrCreate(username).subscribe({
        next: (value) => {
          UserHelper.saveUuid(value.uuid);
          this.router.navigate(['/habit-display']);
        }
      }
      )
  }
}
