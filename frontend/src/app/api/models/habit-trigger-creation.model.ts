import {TriggerModel} from './trigger.model';
import {HabitModel} from './habit.model';

export interface HabitTriggerCreationModel extends TriggerModel {
  habits: string[]
}
