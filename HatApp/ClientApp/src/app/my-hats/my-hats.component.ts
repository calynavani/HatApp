import { Component, Input, OnInit } from '@angular/core';
import {ActivatedRoute} from '@angular/router';
import {UserObject, UOConvert} from '../UserObject';
import { UserService } from '../user.service';
import { Hat } from '../Hat';


@Component({
  selector: 'app-my-hats',
  templateUrl: './my-hats.component.html',
  styleUrls: ['./my-hats.component.css'],
  providers: [UserService]
})
export class MyHatsComponent implements OnInit {
currentUser:UserObject;
id = Number(this.route.snapshot.paramMap.get('id'));
  constructor(private userService: UserService, private route: ActivatedRoute) {
  this.userService.GetUserObject(this.id).subscribe(
    (response: any)=>{
      let json = UOConvert.userObjectToJson(response);
      this.currentUser = UOConvert.toUserObject(json);      
    }
  )

}

ngOnInit() {
}

}
