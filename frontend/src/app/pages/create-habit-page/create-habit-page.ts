import { Component, signal, inject, OnInit } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { MatRadioModule } from '@angular/material/radio';
import { FormControl, FormGroup, ReactiveFormsModule} from '@angular/forms';
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {provideNativeDateAdapter} from '@angular/material/core';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButton } from "@angular/material/button";
import {MatButtonToggleModule} from '@angular/material/button-toggle';
import {ChangeDetectionStrategy} from '@angular/core';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';
import {MatSnackBar} from '@angular/material/snack-bar';
import { UserApi } from '../../api/services/user.api';
import { UserModel } from '../../api/models/user.model';
import {MatSelectModule} from '@angular/material/select';
import {TriggerTypeEnum} from '../../api/enums/trigger-type.enum';
import { HabitApi } from '../../api/services/habit.api';

@Component({
  selector: 'app-create-habit-page',
  imports: [
    MatFormFieldModule,
    MatCardModule,
    MatRadioModule,
    ReactiveFormsModule,
    MatDatepickerModule,
    MatCheckboxModule,
    MatInputModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatIconModule,
    MatSelectModule
],
  providers: [provideNativeDateAdapter()],
  templateUrl: './create-habit-page.html',
  styleUrl: './create-habit-page.scss',
  standalone: true
})
export class CreateHabitPage implements OnInit{
  protected userList: UserModel[]=[]

  protected habitForm = new FormGroup({
    name: new FormControl(''),
    description: new FormControl(''),
    startDate: new FormControl(new Date()),
    endDate: new FormControl(new Date()),
    triggerType: new FormControl(TriggerTypeEnum.Habit),
    godFather: new FormControl(''),
    weekdays: new FormControl([]),
  });

  constructor (private userApi: UserApi, private _habitApi: HabitApi) {}

  ngOnInit(): void {
    this.userApi.getAll().subscribe(u=>
      this.userList = u
    );

  }

  private _snackBar = inject(MatSnackBar);

  displayDateTriggerInfo(): void {
    this._snackBar.open("Set a Date when your habit will be triggered. This should be the date on which you want to do it.",
      'Close',
    {
      duration: 10000, // 👈 10s = 10000 ms
    }
    );
  }

  displayHabitStackInfo(): void {
    this._snackBar.open("Set this habit to trigger once you've completed another habit. This process is called habit stacking.",
      'Close',
    {
      duration: 10000, // 👈 10s = 10000 ms
    });
  }

  openUserList(){

  }

  onsubmit(){
    let habit: HabitModel={
      Name: this.habitForm.value.name!,
      Uuid: '',
      Description: this.habitForm.value.description!,
      Trigger: {
        Uuid: '',
        Type: this.habitForm.value.triggerType!,
        Occurrence: {
          Date: this.habitForm.value.startDate!,
          IsAchieved: false
        },
        Cycle: {
          StartDate: this.habitForm.value.startDate!,
          EndDate: this.habitForm.value.endDate!,
          Weekdays: this.habitForm.value.weekdays!
        }}
      }
      this._habitApi.createHabit(habit).subscribe(
        value => console.log(value as HabitModel)
      )
    }


  protected readonly TriggerTypeEnum = TriggerTypeEnum;
}

  




