import { Component, OnInit } from '@angular/core';
import { User } from '../models/user';
import { UserSevice } from '../services/user.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.sass'
})
export class AppComponent implements OnInit{
  
  title = 'FirstProject';
  users: User[] = [];
  
  constructor(private userService : UserSevice ){}

  ngOnInit(): void{
    this.userService.getAll().subscribe(data => {
      this.users = data;
    });
  }

  onButtonClick() : void {
      let user = new User();
      user.id = 0;
      user.email = "userAdd@userAdd";
      user.password = "userAdded";
      this.userService.add(user).subscribe(data => {
        console.log("User is saved");
      });
    }
}
