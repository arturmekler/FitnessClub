import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class LessonScheduleService {
  private headers: HttpHeaders;
  private accessPointUrl: string = 'https://localhost:44358/api/users';
  
  constructor(private http: HttpClient) {
    this.headers = new HttpHeaders({'Content-Type': 'application/json; charset=utf-8'});
  }

  public get() {
    // Get all jogging data
    return this.http.get(this.accessPointUrl, {headers: this.headers});
  }


}
