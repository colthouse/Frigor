import { Routes } from '@angular/router';
import { GabiSpace } from './pages/gabi-space/gabi-space';
import { JannisSpace } from './pages/jannis-space/jannis-space';
import { FylSpace } from './pages/fyl-space/fyl-space';

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
        path: `fyl`,
        component: FylSpace,
        pathMatch: 'full',
      },
  ];
