import {TriggerModel} from './trigger.model';

export interface CycleTriggerModel extends TriggerModel {
  startDate: Date;
  endDate: Date;
  daysOfWeek: number[];
}
