import { Component } from '@angular/core';
import { FormControl, ReactiveFormsModule } from '@angular/forms';
import { UserApi } from '../../api/services/user.api';
import { MatFormFieldModule } from "@angular/material/form-field";
import { MatInputModule } from "@angular/material/input";
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'login-page',
  standalone: false,
  templateUrl: './login.page.html',
  styleUrl: './login.page.scss'
})
export class LoginPage {
  usernameInput = new FormControl('');


  constructor(private _userApi: UserApi) {}

  submit() {
    console.log("asfd")
    let username: string | null = this.usernameInput.value;

    if (username == null) return;
    console.log("asdd")

    this._userApi.loadOrCreate(username).subscribe(
      value => console.log('User UUID is.' + value)
    );
  }

  saveUuid(id:number) {
    
  }
}
