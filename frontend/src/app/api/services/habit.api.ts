import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { UrlHelper } from '../../helpers/url.helper';
import { UserHelper } from '../../helpers/user.helper';
import { HabitModel } from '../models/habit.model';
import {HabitCreationModel} from '../models/habit-creation.model';

@Injectable({
  providedIn: 'root'
})
export class HabitApi {

  public basePath: string;

  constructor(private _httpClient: HttpClient) {
    this.basePath = UrlHelper.getApiBase() + 'habit/';
  }

  createHabit(habit: HabitModel): Observable<HabitModel> {
    let uuid = this.getUuid();
    return this._httpClient.post<HabitModel>(this.basePath+uuid, habit)
  }

  getHabits(): Observable<HabitModel[]> {
    let uuid = this.getUuid();
    return this._httpClient.get<HabitModel[]>(`${this.basePath}${uuid}`)
  }

  getGodparentHabits() : Observable<HabitModel[]> {
    let uuid = this.getUuid();
    return this._httpClient.get<HabitModel[]>(`${this.basePath}/godparent/${uuid}`)
  }

  deleteHabit() : Observable<void> {
    let uuid = this.getUuid();
    return this._httpClient.delete<void>(`${this.basePath}${uuid}`)
  }

  habitAchieved(checked: boolean) : Observable<object> {
    let uuid = this.getUuid();
    return this._httpClient.get<object>(`${this.basePath}${uuid}/${checked}`)
  }

  private getUuid(): string{
    return UserHelper.getUuid()
  }
}
