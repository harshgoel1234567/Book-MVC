import { BookListComponent } from './Components/Book-List/Book-List.component';
import { AppComponent } from './app.component';
import { LoginComponent } from './Components/Login/Login.component';
import { RouterModule, Routes } from '@angular/router';
import { AddNewBookComponent } from './Components/Add-NewBook/Add-NewBook.component';
import { NgModule } from '@angular/core';
const routes:Routes=[
{
  path:'Login',
  component:LoginComponent
},
{
  path:'BookList',
  component:BookListComponent
},
{
  path:'Add',
  component:AddNewBookComponent
}
]


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
