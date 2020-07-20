import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './Components/login/login.component';
import { HomeComponent } from './Components/home/home.component';
import { AdminComponent } from './Components/admin/admin.component';
import { P404Component } from './Components/p404/p404.component';
import { TeamsComponent } from './Components/teams/teams.component';
import { QuestionaireComponent } from './Components/questionaire/questionaire.component';
import { ProjectsComponent } from './Components/projects/projects.component';


const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'projects', component: ProjectsComponent},
  {path: 'admin', component: AdminComponent},
  {path: 'questionaire', component: QuestionaireComponent},
  {path: 'login', component: LoginComponent},
  {path: 'team', component: TeamsComponent},
  {path:'**', component: P404Component}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
