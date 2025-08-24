import {HabitModel} from './habit.model';

export interface OccurrenceModel {
  date: Date;
  isAchieved: boolean;
  Habit: HabitModel;
}
