import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LogVM } from './log.model';

@Injectable({
  providedIn: 'root'
})
export class LogServices {
  constructor(private http: HttpClient) { }

  create(log: LogVM, baseUrl: string): Observable<boolean> {
    return this.http.post<boolean>(baseUrl + 'api/log', log);
  }

  read(baseUrl: string): Observable<LogVM[]> {
    return this.http.get<LogVM[]>(baseUrl + 'api/log');
  }

  readById(baseUrl: string, id: string): Observable<LogVM> {
    const url = `${baseUrl}api/log/${id}`;

    return this.http.get<LogVM>(url);
  }

  update(baseUrl: string, log: LogVM): Observable<boolean> {
    return this.http.put<boolean>(baseUrl + 'api/log', log);
  }

  delete(baseUrl: string, id: string): Observable<boolean> {
    const url = `${baseUrl}api/log/${id}`;
    return this.http.delete<boolean>(url);
  }
}
