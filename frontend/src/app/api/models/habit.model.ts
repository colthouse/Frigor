import { TriggerModel } from "./trigger.model";

export interface HabitModel {
    Uuid: string;
    Name: string
    Description: string;
    Trigger: TriggerModel;
}
