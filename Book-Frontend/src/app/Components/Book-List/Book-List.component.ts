import { BookService } from './../../../Services/Book.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-Book-List',
  templateUrl: './Book-List.component.html',
  styleUrls: ['./Book-List.component.css']
})
export class BookListComponent implements OnInit {

  constructor(private service:BookService) { }

  book:any[]=[
    {
    id:"",
    book_Name:"",
    rating:0,
    author:"",
    genre:"",
    aavailability_status:true,
    description:"",
    lent_Id:"",
    borrowed_Id:""
    }

]
  ngOnInit() {

    this.service.getAllBooks().subscribe(

        (data:any[])=>
        {
          console.log(data);
          this.book=data;

          console.log("datais",this.book);


        },
        (error)=>
        {
    console.log(error);
        }

    )
  }

}
