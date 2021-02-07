import { Component, Inject } from '@angular/core';
import { Router } from '@angular/router';
import { LogVM } from '../../log.model';
import { LogServices } from '../../log.services';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public logs: LogVM[];
  baseUrl: string;
  constructor(private logServices: LogServices, private router: Router, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  ngOnInit(): void {
    this.logServices.read(this.baseUrl).subscribe(result => {
      this.logs = result;
    }, error => alert(error));
  }

  delete(id: string): void {
    if (confirm('Tem certeza que deseja excluir este log?')) {
      this.logServices.delete(this.baseUrl, id).subscribe(() => {
        alert('Log excluído com sucesso!');
        this.logServices.read(this.baseUrl).subscribe(result => {
          this.logs = result;
        }, error => alert(error));
      });
    }
  }
}
