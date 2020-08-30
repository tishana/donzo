import { Routes } from '@angular/router'
import { HomeComponent } from './home/home.component'
import { WorkoutListComponent } from './workout-list/workout-list.component'
export const appRoutes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: 'workouts', component: WorkoutListComponent },
  { path: '**', redirectTo: 'home', pathMatch: 'full' },
]
