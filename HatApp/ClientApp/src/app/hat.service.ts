import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Hat } from './Hat';

@Injectable({
  providedIn: 'root'
})
export class HatService {
  url: string ="HatAPI";
  constructor(private http:HttpClient, @Inject('BASE_URL')baseUrl:string) { 
    this.url = baseUrl + this.url;
  }

  GetHat(id:number): Observable<any>{
    return(this.http.get(this.url +"/get/" +id));
  }

  GetAllHats(): Observable<any>{
    return this.http.get<Hat>(this.url +"/hats/");
  }
  DeleteHat(id:number) {
    return this.http.delete(this.url + "/DeleteMyHat/{id}");
    }
}
