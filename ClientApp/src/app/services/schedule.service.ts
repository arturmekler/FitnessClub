import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';
import { of } from 'rxjs/observable/of';
import { Schedule } from './Models/Schedule';

@Injectable()
export class ScheduleService {

  apiUrl = 'http://192.168.0.5:5000/api/book';

  constructor(private http: HttpClient) { }

  getSchedule(): Observable<Schedule[]> {
    return this.http.get<Schedule[]>(this.apiUrl + 'schedule')
      .pipe(
        tap(_ => this.log('fetched schedules')),
        catchError(this.handleError('getSchedule', []))
      );
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // TODO: better job of transforming error for user consumption
      this.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }

  /** Log a HeroService message with the MessageService */
  private log(message: string) {
    console.log(message);
  }
}