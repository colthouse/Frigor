import { TriggerTypeEnum } from "../enums/trigger-type.enum";
import { CycleModel } from "./cycle.model";
import { OccurrenceModel } from "./occurrence.model";

export interface TriggerModel {
    Uuid: string;
    Type: TriggerTypeEnum;
    Occurrence: OccurrenceModel;
    Cycle: CycleModel;
}
