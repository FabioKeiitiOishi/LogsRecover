import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public logs: LogVM[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<LogVM[]>(baseUrl + 'api/log').subscribe(result => {
      this.logs = result;
    }, error => console.error(error));
  }
}

interface LogVM {
  id: number;
  ip: string;
  recordedTime: Date;
  userAgent: string;
}
