import { Component, Inject } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { FileUploadService } from '../../../file-upload.service';

@Component({
  selector: 'file-upload',
  templateUrl: './file-upload.component.html',
  styleUrls: ['./file-upload.component.css']
})
export class FileUploadComponent {
  myForm = new FormGroup({
    file: new FormControl(),
    fileSource: new FormControl()
  });
  baseUrl: string;

  constructor(
    private fileUploadServices: FileUploadService,
    @Inject('BASE_URL') baseUrl: string)
  {
    this.baseUrl = baseUrl;
  }

  onFileChange(files: FileList) {
    if (files.length > 0) {
      if (files.item(0).name.indexOf('.log') == -1) {
        alert('O arquivo está em formato incorreto.');
        return;
      }
      const file = files[0];
      this.myForm.patchValue({
        fileSource: file
      });
    }
  }

  submit() {
    const formData = new FormData();
    formData.append('file', this.myForm.get('fileSource').value);

    this.fileUploadServices.postFile(this.baseUrl, formData);
  }
}
