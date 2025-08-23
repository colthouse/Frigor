import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HabitDisplayComponent } from './habit-display.component';

describe('HabitDisplayComponent', () => {
  let component: HabitDisplayComponent;
  let fixture: ComponentFixture<HabitDisplayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HabitDisplayComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HabitDisplayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
