import {TriggerModel} from './trigger.model';
import {HabitModel} from './habit.model';

export interface HabitTriggerModel extends TriggerModel {
  habits: HabitModel[]
}
