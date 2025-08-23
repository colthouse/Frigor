import { DayOfWeekEnum } from "../enums/day-of-week.enum"

export interface CycleModel {
    startDate: Date
    endDate: Date
    weekdays: DayOfWeekEnum[]
}
