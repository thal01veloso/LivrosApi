import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LivroComponent } from 'src/livro/livro.component';
import {HttpClientModule} from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ServiceComponent } from 'src/service/service.component';

@NgModule({
  declarations: [
    AppComponent,
    LivroComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],

  providers: [ServiceComponent,HttpClientModule],
  bootstrap: [AppComponent]
})
export class AppModule { }
