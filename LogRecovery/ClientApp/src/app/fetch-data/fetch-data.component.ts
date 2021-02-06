import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { LogVM } from '../../log.model';
import { LogServices } from '../../log.services';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public logs: LogVM[];
  baseUrl: string;
  constructor(private logServices: LogServices, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  ngOnInit(): void {
    this.logServices.read(this.baseUrl).subscribe(result => {
      this.logs = result;
    }, error => console.error(error));
  }
}
