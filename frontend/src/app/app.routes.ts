import { Routes } from '@angular/router';
import { JannisSpace } from './pages/jannis-space/jannis-space';
import { FylSpace } from './pages/fyl-space/fyl-space';
import { LoginPage } from './pages/login/login.page';
import { CreateHabitPage } from './pages/create-habit-page/create-habit-page';
import { HabitDisplayComponent } from './pages/habit-display/habit-display.component';
import { WelcomeComponent } from './welcome/welcome.component';
import { ResponsibilitiesOverviewComponent } from './pages/responsibilities/responsibilities-overview.component';

export const routes: Routes = [
      {
        path: `habit-display`,
        component: HabitDisplayComponent,
        pathMatch: 'full',
      },
      {
        path: `jannis`,
        component: JannisSpace,
        pathMatch: 'full',
      },
      {
        path: `login`,
        component: LoginPage,
        pathMatch: 'full',
      },
      {
        path: `fyl`,
        component: FylSpace,
        pathMatch: 'full',
      },
      {
        path: 'create-habit',
        component: CreateHabitPage,
        pathMatch: 'full',
      },
      {
        path: 'welcome',
        component: WelcomeComponent,
        pathMatch: 'full',
      },
      {
        path: 'responsibilities',
        component: ResponsibilitiesOverviewComponent,
        pathMatch: 'full',
      },
  ];
