import { Component } from '@angular/core';
import { FormControl, ReactiveFormsModule } from '@angular/forms';
import { UserApiService } from '../../api/services/user-api.service';

@Component({
  selector: 'app-login-page',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './login-page.component.html',
  styleUrl: './login-page.component.scss'
})
export class LoginPageComponent {

  usernameInput = new FormControl('');

   alertName() {    
    alert(this.userApi.newMethod);  
  }

  constructor(private userApi:UserApiService) {

  }

}
