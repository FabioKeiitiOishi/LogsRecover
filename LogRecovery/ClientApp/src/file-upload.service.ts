import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FileUploadService {
  constructor(private http: HttpClient) { }

  postFile(baseUrl: string, formData: FormData): Observable<boolean> {

    return this.http.post<boolean>(baseUrl + 'api/log/list', formData);
  }
}
