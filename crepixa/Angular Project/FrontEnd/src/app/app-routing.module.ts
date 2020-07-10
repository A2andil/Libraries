import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './Components/login/login.component';
import { HomeComponent } from './Components/home/home.component';
import { AdminComponent } from './Components/admin/admin.component';
import { P404Component } from './Components/p404/p404.component';
import { NavBarComponent } from './Components/nav-bar/nav-bar.component';
import { SliderBarComponent } from './Components/slider-bar/slider-bar.component';


const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'admin', component: AdminComponent},
  {path: 'slide', component: SliderBarComponent},
  {path: 'bar', component: NavBarComponent},
  {path: 'admin/login', component: LoginComponent},
  {path:'**', component: P404Component}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
