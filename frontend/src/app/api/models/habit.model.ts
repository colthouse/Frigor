import {UserModel} from './user.model';
import {HabitInterface} from './habit-interface.model';

export interface HabitModel extends HabitInterface {
    owner: UserModel;
    godParent: UserModel;
    uuid: string;
}
