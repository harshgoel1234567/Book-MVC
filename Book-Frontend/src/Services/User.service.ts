import { Injectable } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from 'src/app/models/model';
import {JwtHelperService} from '@auth0/angular-jwt'
@Injectable({
  providedIn: 'root'
})
export class UserService {


constructor(private http:HttpClient) {}
  loginuser(user:User): Observable<{ token: string }>
  {
    return this.http.post<{ token: string }>('http://localhost:5273/api/User/Loginuser', user);
  }



}
