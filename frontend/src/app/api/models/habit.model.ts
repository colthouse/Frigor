import { TriggerModel } from "./trigger.model";

export interface HabitModel {
    uuid: string;
    name: string
    description: string;
    trigger: TriggerModel;
    godparentUserId: string | null; 
    ownerId: string;
}
