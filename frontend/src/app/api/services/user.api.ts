import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { UserModel } from '../models/user.model';
import { Observable } from 'rxjs';
import { UrlHelper } from '../../helpers/url.helper';

@Injectable({
  providedIn: 'root'
})
export class UserApi {
  public basePath: string;

  constructor(private _httpClient: HttpClient) {
    this.basePath = UrlHelper.getApiBase() + 'user/';
  }

  loadOrCreate(name: string): Observable<UserModel> {
    return this._httpClient.post<UserModel>(this.basePath + name, {})
  }
}
