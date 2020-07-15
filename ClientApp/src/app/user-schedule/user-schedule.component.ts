import { Component, OnInit } from '@angular/core';
import { ScheduleService } from '../services/schedule.service';
import { AuthService } from '../services/auth.service';
import { Router } from '@angular/router';
import { Schedule } from '../Models/Schedule';

@Component({
  selector: 'app-user-schedule',
  templateUrl: './user-schedule.component.html',
  styleUrls: ['./user-schedule.component.css']
})
export class UserScheduleComponent implements OnInit {

  constructor(private scheduleService : ScheduleService, private authService : AuthService, private router : Router) { }

  data: Schedule[] = [];
  isLoadingResults = true;
  
  getSchedule(): void {
    debugger
    this.scheduleService.getSchedule()
      .subscribe(schedule=>{
        this.data = schedule;
        this.isLoadingResults = false;
      }, err=>{
        console.log(err);
        this.isLoadingResults = false;
      })
    }

  ngOnInit() {
    this.getSchedule();
  }

}
