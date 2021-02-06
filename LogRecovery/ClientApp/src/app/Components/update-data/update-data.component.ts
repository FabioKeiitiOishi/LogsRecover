import { Component, Inject, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { LogVM } from '../../../log.model';
import { LogServices } from '../../../log.services';

@Component({
  selector: 'update-data',
  templateUrl: './update-data.component.html',
  styleUrls: ['./update-data.component.css']
})
export class UpdateDataComponent {
  log: LogVM = {
    id: null,
    ip: '',
    recordedTime: null,
    userAgent: ''
  };
  baseUrl: string;

  constructor(
    private logServices: LogServices,
    private router: Router,
    private route: ActivatedRoute,
    @Inject('BASE_URL') baseUrl: string
  ) {
    this.baseUrl = baseUrl
  }

  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id');
    this.logServices.readById(this.baseUrl, id).subscribe(logResult =>
      this.log = logResult)
  }

  updateLog(): void {
    this.logServices.update(this.baseUrl, this.log).subscribe(() => {
      alert('Log atualizado com sucesso!');
      this.router.navigate(['']);
    });
  }

  cancel(): void {
    this.router.navigate([''])
  }
}
