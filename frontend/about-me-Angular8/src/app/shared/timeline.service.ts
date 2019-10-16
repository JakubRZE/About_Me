import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { tap, catchError, map } from 'rxjs/operators';
import { IHeader } from '../interface/IHeader';
import { ICategory } from '../interface/ICategory';
import { IEventDetail } from '../interface/IEventDetail';

@Injectable({
  providedIn: 'root'
})
export class TimelineService {
  private rootUrl = 'http://localhost:59695/api';
  

  constructor(private http: HttpClient) { }

  getHeader(): Observable<IHeader> {
    return this.http.get<IHeader>(this.rootUrl + "/headers").pipe(
      tap(data => console.log('Response: ' + JSON.stringify(data))),
      catchError(this.handleError)
    );
  }

  getCategories(): Observable<ICategory[]> {
    return this.http.get<ICategory[]>(this.rootUrl + "/categories").pipe(
      tap(data => console.log('Response: ' + JSON.stringify(data))),
      catchError(this.handleError)
    );
  }

  getEventsByCategoryId(id: number): Observable<IEventDetail[] | undefined> {
    return this.http.get<IEventDetail[]>(this.rootUrl + "/eventdetails/" + id).pipe(
      tap(data => console.log('Response: ' + JSON.stringify(data))),
      catchError(this.handleError)
    );
  }

  private handleError(err: HttpErrorResponse) {
    // in a real world app, we may send the server to some remote logging infrastructure
    // instead of just logging it to the console
    let errorMessage = '';
    if (err.error instanceof ErrorEvent) {
      // A client-side or network error occurred. Handle it accordingly.
      errorMessage = `An error occurred: ${err.error.message}`;
    } else {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong,
      errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
    }
    console.error(errorMessage);
    return throwError(errorMessage);
  }

}
