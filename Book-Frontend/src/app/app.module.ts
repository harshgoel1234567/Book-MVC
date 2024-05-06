import { BookListComponent } from './Components/Book-List/Book-List.component';
import { Book } from 'src/app/models/model';
import { AddNewBookComponent } from './Components/Add-NewBook/Add-NewBook.component';
import { LoginComponent } from './Components/Login/Login.component';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import {  HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    AddNewBookComponent,
    BookListComponent


  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    CommonModule,
    HttpClientModule,

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
