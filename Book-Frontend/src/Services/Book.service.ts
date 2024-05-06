import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Book } from 'src/app/models/model';
import { HttpClient, HttpClientModule } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class BookService {

constructor(private http:HttpClient) {}

  AddBook(book:Book):Observable<any>
  {
    return this.http.post<Book>('http://localhost:5273/api/Book', book);
  }
  getAllBooks():Observable<any>
  {
    return this.http.get<any[]>('http://localhost:5273/api/Book');
  }


}
