import {UserModel} from './user.model';

export interface HabitModel {
    owner: UserModel;
    godParent: UserModel;
}
