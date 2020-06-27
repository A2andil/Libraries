import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TestingApiComponent } from './testing-api/testing-api.component';
import {HttpClientModule} from '@angular/common/http' ;

@NgModule({
  declarations: [
    AppComponent,
    TestingApiComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
