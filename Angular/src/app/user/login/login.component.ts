import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms'
import { UserService } from 'src/app/shared/user.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styles: []
})
export class LoginComponent implements OnInit {
  formModel ={
    UserName: '',
    Password: ''
  }
  constructor(private service: UserService,private router: Router) { }

  ngOnInit() {
    if(localStorage.getItem('token')!=null)
      this.router.navigateByUrl('/home')
  }

  onSubmit(form:NgForm){
    this.service.login(form.value).subscribe(
      (res: any) =>{
        localStorage.setItem('token',res.token);
        this.router.navigateByUrl('/calendar');
      },
      err=> {
        if(err.status == 400)
          console.log('Incorrect username or password');
          else
          console.log(err);
      }
    );
  }
}
