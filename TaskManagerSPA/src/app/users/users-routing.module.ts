import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from '../home/home.component';
import { TaskListComponent } from './task-list/task-list.component';
import { UsersComponent } from './users.component';

const routes: Routes = [
  { path: "", component: UsersComponent,
    children: [
      { path: "", component: HomeComponent },
      { path: ":id/tasklist", component: TaskListComponent }
    ]}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class UsersRoutingModule { }
