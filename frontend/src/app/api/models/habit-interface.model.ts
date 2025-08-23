import { TriggerModel } from "./trigger.model";
import {UserModel} from './user.model';
import {OccurrenceModel} from './occurrence.model';
import {HabitTriggerModel} from './habit-trigger.model';

export interface HabitInterface {
    name: string
    description: string;
    trigger: TriggerModel;
    habitTriggers: HabitTriggerModel[];
    occurrences: OccurrenceModel[];
}
