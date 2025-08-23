import { TriggerTypeEnum } from "../enums/trigger-type.enum";
import { CycleModel } from "./cycle.model";
import { OccurrenceModel } from "./occurrence.model";

export interface TriggerModel {
    uuid: string;
    type: TriggerTypeEnum;
    occurrence: OccurrenceModel;
    cycle: CycleModel;
    habits: string[];
}
