import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HomeComponent } from './Components/home/home.component';
import { LoginComponent } from './Components/login/login.component';
import { AdminComponent } from './Components/admin/admin.component';
import { P404Component } from './Components/p404/p404.component';
import { NavBarComponent } from './Components/nav-bar/nav-bar.component';
import { SliderBarComponent } from './Components/slider-bar/slider-bar.component';
import { FooterComponent } from './Components/footer/footer.component';
import { ContactComponent } from './Components/contact/contact.component';
import { ServicesComponent } from './Components/services/services.component';
import { ProfilesComponent } from './Components/profiles/profiles.component';
import { TeamsComponent } from './Components/teams/teams.component';
import { TeamHeaderComponent } from './Components/team-header/team-header.component';
import { NavBarTeamComponent } from './Components/nav-bar-team/nav-bar-team.component';
import { QuestionaireComponent } from './Components/questionaire/questionaire.component';
import { QuestionaireHeaderComponent } from './Components/questionaire-header/questionaire-header.component';
import { ProjectsComponent } from './Components/projects/projects.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LoginComponent,
    AdminComponent,
    P404Component,
    NavBarComponent,
    SliderBarComponent,
    FooterComponent,
    ContactComponent,
    ServicesComponent,
    ProfilesComponent,
    TeamsComponent,
    TeamHeaderComponent,
    NavBarTeamComponent,
    QuestionaireComponent,
    QuestionaireHeaderComponent,
    ProjectsComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
