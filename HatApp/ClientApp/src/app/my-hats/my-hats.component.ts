import { Component, Input, OnInit } from '@angular/core';
import { Hat } from '../Hat';
import { User } from '../User';
import { UserService } from '../user.service';
import { HatService } from '../hat.service';

@Component({
  selector: 'app-my-hats',
  templateUrl: './my-hats.component.html',
  styleUrls: ['./my-hats.component.css'],
  providers: [UserService, HatService]
})
export class MyHatsComponent implements OnInit {
currentUser:User;
@Input()  Id:number;
  constructor(private userService: UserService, private hatService:HatService) { 
  this.userService.GetUser(this.Id).subscribe(
    (response: any) => (this.currentUser = response)
  );
}

ngOnInit() {
}

}
