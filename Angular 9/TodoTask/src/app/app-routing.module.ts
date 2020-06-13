import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { TaskComponent } from './components/task/task.component';
import { Error404Component } from './components/error404/error404.component';
import { InsertionComponent } from './components/insertion/insertion.component';


const routes: Routes = [
  { path:'', component: HomeComponent },
  { path: 'task', component: InsertionComponent },
  { path: 'task/:id', component: TaskComponent },
  { path:'**', component:Error404Component }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {

}
