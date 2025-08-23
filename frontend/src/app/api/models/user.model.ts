import {HabitModel} from './habit.model';

export interface UserModel {
  uuid: string;
  name: string;
  habits: HabitModel[]
}
