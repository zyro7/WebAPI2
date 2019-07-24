import { Injectable } from '@angular/core';
import { CalendarDetail } from './calendar-detail.model';
import { HttpClient } from '@angular/common/http'
@Injectable({
  providedIn: 'root'
})
export class CalendarDetailService {
  formData :CalendarDetail;
  readonly rootURL = 'http://localhost:50020/api';
  list : CalendarDetail[];

  constructor(private http:HttpClient) { }

  postCalendarDetail(){
    return this.http.post(this.rootURL + '/HourDetails',this.formData);
  }
  
  putCalendarDetail(){
    return this.http.put(this.rootURL + '/HourDetails/'+ this.formData.HourId,this.formData);
  }
  
  deleteCalendarDetail(id){
    return this.http.delete(this.rootURL + '/HourDetails/'+ id);
  }

  refreshList() {
    this.http.get(this.rootURL + '/HourDetails')
    .toPromise()
    .then(res => this.list = res as CalendarDetail[])
  }
}
