import { TriggerModel } from "./trigger.model";
import {UserModel} from './user.model';
import {OccurrenceModel} from './occurrence.model';
import {HabitTriggerModel} from './habit-trigger.model';
import {HabitInterface} from './habit-interface.model';

export interface HabitCreationModel extends HabitInterface {
    owner: string;
    godParent: string;
}
