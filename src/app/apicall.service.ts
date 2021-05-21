import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
@Injectable({
  providedIn: 'root'
})
export class ApicallService {

  constructor(private http:HttpClient) { }
  getData=()=>{
    let url="https://localhost:44374/api/employee"
    return this.http.get(url)
  }
  deleteEmployee=(id)=>{
let url="https://localhost:44374/api/employee?id="+id
return this.http.delete(url)
  }
  postEmployee=(employee)=>{
    let url="https://localhost:44374/api/employee"
    return this.http.post(url,employee)
  }
  putEmployee=(id,employee)=>{
    let url="https://localhost:44374/api/employee?id="+id
    return this.http.put(url,employee)
  }
}
