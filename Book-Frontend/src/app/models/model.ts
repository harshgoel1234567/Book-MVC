import { BookService } from './../../Services/Book.service';
export interface User
{
 username:string,
 password:string
}
export interface Book
{
    book_Name:string,
    rating:number,
    author:string,
    genre: string,
    aavailability_status:boolean,
    description:string,
    lent_Id:string,
    borrowed_Id:string

}
