import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HelloWorldService } from './Services/HelloWorldService'
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    HttpModule
  ],
  providers: [HelloWorldService],
  bootstrap: [AppComponent]
})
export class AppModule { }
