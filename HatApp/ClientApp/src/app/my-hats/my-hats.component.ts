import { Component, Input, OnInit } from '@angular/core';
import {ActivatedRoute} from '@angular/router';
import {UserObject, UOConvert} from '../UserObject';
import { UserService } from '../user.service';
import { Hat, HatConvert } from '../Hat';
import { HatService } from '../hat.service';


@Component({
  selector: 'app-my-hats',
  templateUrl: './my-hats.component.html',
  styleUrls: ['./my-hats.component.css'],
  providers: [UserService]
})
export class MyHatsComponent implements OnInit {
currentUser:UserObject;
randomHat: Hat;
allHats: Hat[]=[];

id = Number(this.route.snapshot.paramMap.get('id'));
  constructor(private userService: UserService, private route: ActivatedRoute, private hatService: HatService) {
  this.userService.GetUserObject(this.id).subscribe(
    (response: any)=>{
      let json = UOConvert.userObjectToJson(response);
      this.currentUser = UOConvert.toUserObject(json);      
    }
  );
  this.hatService.GetAllHats().subscribe(
    (response: any)=>{
      let json = HatConvert.hatToJson(response);
      this.allHats = HatConvert.toHat(json);
    }
  );
}

ngOnInit() {
}
randomHatPicker(){
  let target=(<HTMLImageElement>document.getElementById("randomDiv"));
  let i = Math.floor(Math.random())
  for(let i: number=0;i<=this.allHats.length;i++){    
    target.innerHTML='<img id="imgtarget" src="'+this.currentUser.myCollection[i].images+'"/>';
    console.log(this.currentUser.myCollection[i].images);
  }
}

RemoveFromCollection(id: number) {

  this.hatService.DeleteMyHat(id);

}

}
