import { Component, Inject } from '@angular/core';
import { Router } from '@angular/router';
import { LogVM } from '../../../log.model';
import { LogServices } from '../../../log.services';

@Component({
  selector: 'send-informations',
  templateUrl: './send-informations.component.html',
  styleUrls: ['./send-informations.component.css']
})
export class SendInformationsComponent {
  private baseUrl: string;
  constructor(
    private logServices: LogServices,
    private router: Router,
    @Inject('BASE_URL') baseUrl: string) { this.baseUrl = baseUrl }

  log: LogVM = {
    ip: '',
    recordedTime: null,
    userAgent: ''
  };

  createLog(): void {
    this.logServices.create(this.log, this.baseUrl).subscribe(() => {
      alert('Log salvo!');
      this.router.navigate(['']);
    }, error => alert(error));
  }
}
