import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TestingApiComponent } from './testing-api/testing-api.component';
import {HttpClientModule} from '@angular/common/http';
import { LeftHeaderComponent } from './Components/left-header/left-header.component';
import { RightHeaderComponent } from './Components/right-header/right-header.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  declarations: [
    AppComponent,
    TestingApiComponent,
    LeftHeaderComponent,
    RightHeaderComponent
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
