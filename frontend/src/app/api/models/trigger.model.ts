import { TriggerTypeEnum } from "../enums/trigger-type.enum";

export interface TriggerModel {
    uuid: string;
    type: TriggerTypeEnum;
}
