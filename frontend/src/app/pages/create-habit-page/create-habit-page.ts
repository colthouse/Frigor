import {Component, inject, OnInit} from '@angular/core';
import {MatCardModule} from '@angular/material/card';
import {MatRadioModule} from '@angular/material/radio';
import {FormControl, FormGroup, ReactiveFormsModule, Validators} from '@angular/forms';
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {provideNativeDateAdapter} from '@angular/material/core';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatInputModule} from '@angular/material/input';
import {MatButtonModule} from "@angular/material/button";
import {MatButtonToggleModule} from '@angular/material/button-toggle';
import {MatIconModule} from '@angular/material/icon';
import {MatSnackBar} from '@angular/material/snack-bar';
import {UserApi} from '../../api/services/user.api';
import {UserModel} from '../../api/models/user.model';
import {MatSelectModule} from '@angular/material/select';
import {TriggerTypeEnum} from '../../api/enums/trigger-type.enum';
import {HabitModel} from '../../api/models/habit.model';
import {NgIf} from '@angular/common';
import {HabitApi} from '../../api/services/habit.api';
import {Router} from '@angular/router';
import {TriggerModel} from '../../api/models/trigger.model';
import {CycleTriggerModel} from '../../api/models/cycle-trigger.model';
import {HabitTriggerModel} from '../../api/models/habit-trigger.model';
import {HabitCreationModel} from '../../api/models/habit-creation.model';
import {HabitTriggerCreationModel} from '../../api/models/habit-trigger-creation.model';

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
    MatSelectModule,
    NgIf,

  ],
  providers: [provideNativeDateAdapter()],
  templateUrl: './create-habit-page.html',
  styleUrl: './create-habit-page.scss',
  standalone: true
})
export class CreateHabitPage implements OnInit {
  options: HabitModel[] = [];

  protected userList: UserModel[] = []
  protected habitForm = new FormGroup({
    name: new FormControl('', Validators.required),
    description: new FormControl('', Validators.required),
    godFather: new FormControl('', Validators.required),
    triggerType: new FormControl(TriggerTypeEnum.Habit, Validators.required),
    startDate: new FormControl(new Date()),
    endDate: new FormControl(new Date()),
    weekdays: new FormControl([]),
    habits: new FormControl([]),
  });
  private _snackBar = inject(MatSnackBar);

  constructor(private userApi: UserApi, private habitApi: HabitApi, private router: Router) {
  }

  protected get triggerIsCycle(): boolean {
    return this.habitForm.value.triggerType == TriggerTypeEnum.Cycle
  }

  ngOnInit(): void {
    this.userApi.getAll().subscribe(u =>
      this.userList = u
    );

    this.habitApi.getHabits(localStorage.getItem('uuid')!).subscribe(h => this.options = h)

  }

  displayDateTriggerInfo(): void {
    this._snackBar.open("Set a Date when your habit will be triggered. This should be the date on which you want to do it.",
      'Close',
      {
        duration: 7000, // 👈 10s = 10000 ms
      }
    );
  }

displayHabitStackInfo(): void {
  this._snackBar.open(
    "Set this habit to trigger once you've completed another habit. This process is called habit stacking.",
    'Close',
    {
      duration: 7000, // 10 seconds
      panelClass: ['snackbar'] // 👈 Add your custom class here
    }
  );
}


  onsubmit() {
    if (this.habitForm.invalid) {
      return
    }

    let trigger: TriggerModel;
    if (this.habitForm.value.triggerType == TriggerTypeEnum.Cycle) {
      trigger = {
        type: TriggerTypeEnum.Cycle,
        startDate: this.habitForm.value.startDate,
        endDate: this.habitForm.value.endDate,
        daysOfWeek: this.habitForm.value.weekdays
      } as unknown as CycleTriggerModel
    }else {
      trigger = {
        type: TriggerTypeEnum.Habit,
        habit: this.habitForm.value.habits
      } as unknown as HabitTriggerCreationModel
    }

    let habit: HabitCreationModel = {
      name: this.habitForm.value.name!,
      description: this.habitForm.value.description!,
      godParent: this.habitForm.value.godFather!,
      owner: localStorage.getItem('uuid')!,
      trigger: trigger,
      occurrences: [],
      habitTriggers: [],
    }

    this.habitApi.createHabit(habit).subscribe(() =>
          this.router.navigate(['/habit-display'])
    )
  }
}






