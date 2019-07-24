import { Component, OnInit } from '@angular/core';
import { CalendarDetailService } from 'src/app/shared/calendar-detail.service';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-calendar-detail',
  templateUrl: './calendar-detail.component.html',
  styles: []
})
export class CalendarDetailComponent implements OnInit {

  constructor(private service : CalendarDetailService,
    private toastr: ToastrService) {
    
   }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?:NgForm){
    if(form != null)
      form.form.reset();
    this.service.formData = {
      HourId :0,
      Hour :'',
      Day:'',
      TattooArtist:'',
      Client:''
    }
  }

  onSubmit(form:NgForm){
    if(this.service.formData.HourId==0)
      this.insertRecord(form);
    else 
      this.updateRecord(form)
  }

  insertRecord(form:NgForm){
    this.service.postCalendarDetail().subscribe(
      res=> {
        this.resetForm(form);
        this.toastr.success('Submitted successfully','Hora reservada')
        this.service.refreshList();
      },
      err=> {
        console.log(err);
      }
    )
  }
  
  updateRecord(form:NgForm){
    this.service.putCalendarDetail().subscribe(
      res=> {
        this.resetForm(form);
        this.toastr.success('Submitted successfully','Hora reservada')
        this.service.refreshList();
      },
      err=> {
        console.log(err);
      }
    )
  }

}
