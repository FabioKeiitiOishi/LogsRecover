import { Component, Inject } from '@angular/core';

@Component({
  selector: 'app-send-data',
  templateUrl: './send-data.component.html'
})
export class SendDataComponent {

  constructor(@Inject('BASE_URL') baseUrl: string) { }
}
