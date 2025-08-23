import { DayOfWeekEnum } from "../enums/day-of-week.enum"

export interface CycleModel {
    StartDate: Date
    EndDate: Date
    Weekdays: DayOfWeekEnum[]
}
