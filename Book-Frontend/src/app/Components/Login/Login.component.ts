import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/Services/User.service';
import {JwtHelperService} from '@auth0/angular-jwt';
@Component({
  selector: 'app-Login',
  templateUrl: './Login.component.html',
  styleUrls: ['./Login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private service:UserService) { }

  ngOnInit() {
  }
  user:any={
    username:'',
    password:''
  }
  check()
  {
    console.log(this.user.username);
    console.log(this.user.password);


    this.service.loginuser(this.user).subscribe(
      { next:(e)=>
        {
          console.log(e);
          console.log(e.token);

            const jwtHelper=new JwtHelperService();

             var ans=jwtHelper.decodeToken(e.token);
             console.log(ans);


        }

      }
    )
  }


}
