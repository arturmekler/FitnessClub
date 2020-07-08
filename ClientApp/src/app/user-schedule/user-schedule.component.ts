import { Component, OnInit } from '@angular/core';
import { LessonScheduleService } from '../lesson-schedule.service';
import { Observable } from 'rxjs/Observable';
import { p } from '@angular/core/src/render3';
import { User } from '../User';


@Component({
  selector: 'app-user-schedule',
  templateUrl: './user-schedule.component.html',
  styleUrls: ['./user-schedule.component.css']
})
export class UserScheduleComponent implements OnInit {
  users : Array<User>

  constructor(private lessonScheduleService: LessonScheduleService) {
    
    lessonScheduleService.get().subscribe((p)=>{
      this.users = p as Array<User>
    })
   }

  ngOnInit() {

   
  }

}
