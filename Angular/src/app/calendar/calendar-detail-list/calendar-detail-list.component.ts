import { Component, OnInit } from '@angular/core';
import { CalendarDetailService } from '../../shared/calendar-detail.service';
import { CalendarDetail } from 'src/app/shared/calendar-detail.model';
import { ToastrService } from 'ngx-toastr';
import * as $ from 'jquery';

@Component({
  selector: 'app-calendar-detail-list',
  templateUrl: './calendar-detail-list.component.html',
  styles: []
})
export class CalendarDetailListComponent implements OnInit {

  constructor(private service: CalendarDetailService,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }

  populateForm(pd:CalendarDetail) {
    this.service.formData = Object.assign({},pd);
  }

  onDelete(HourId) {
    this.service.deleteCalendarDetail(HourId)
    .subscribe(res=>{
      this.service.refreshList();
      this.toastr.success('Remove succesful')
    },
    err=>{
      console.log(err);
    })
  }
}
