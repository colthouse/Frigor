import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { UserModel } from '../models/user.model';
import { Observable } from 'rxjs';
import { UrlHelper } from '../../helpers/url.helper';
import { HabitModel } from '../models/habit.model';
import { FormGroup } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class HabitApiService {
  public basePath: string;

  constructor(private _httpClient: HttpClient) {
    this.basePath = UrlHelper.getApiBase() + 'habit/';
  }

  createHabit(habit: FormGroup): Observable<HabitModel> {
    return this._httpClient.post<HabitModel>(this.basePath, {})
  }

  getAll(): Observable<UserModel[]>{
    return this._httpClient.get<UserModel[]>(this.basePath + "all", {})
  }

}
