import { Routes } from '@angular/router';
import { GabiSpace } from './pages/gabi-space/gabi-space';
import { JannisSpace } from './pages/jannis-space/jannis-space';
import { FylSpace } from './pages/fyl-space/fyl-space';
import { LoginPage } from './pages/login/login.page';
import { CreateHabitPage } from './pages/create-habit-page/create-habit-page';

export const routes: Routes = [
      {
        path: `gabi`,
        component: GabiSpace,
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
      }
  ];
