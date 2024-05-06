import { Book } from 'src/app/models/model';
import { BookService } from './../../../Services/Book.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-Add-NewBook',
  templateUrl: './Add-NewBook.component.html',
  styleUrls: ['./Add-NewBook.component.css']
})
export class AddNewBookComponent implements OnInit {

  constructor(private service:BookService, private router: Router) { }

  ngOnInit() {
  }
  book:Book={
    book_Name:"",
    rating:0,
    author:"",
    genre:"",
    aavailability_status:true,
    description:"",
    lent_Id:"",
    borrowed_Id:""
  }
  AddBook()
  {
    console.log(this.book);
    this.service.AddBook(this.book).subscribe(
      { next:(e)=>
        {
          console.log(e);


        }

      }
    )
  }

}
