import { TriggerTypeEnum } from "../enums/trigger-type.enum";
import { OccurrenceModel } from "./occurrence.model";

export interface TriggerModel {
    Uuid: string;
    Type: TriggerTypeEnum;
    Occurrence: OccurrenceModel;
}
