import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { SendDataComponent } from './send-data/send-data.component';
import { FileUploadComponent } from './components/file-upload/file-upload.component';
import { SendInformationsComponent } from './components/send-informations/send-informations.component';
import { UpdateDataComponent } from './components/update-data/update-data.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    FetchDataComponent,
    SendDataComponent,
    FileUploadComponent,
    SendInformationsComponent,
    UpdateDataComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'send-data', component: SendDataComponent },
      { path: 'file-upload', component: FileUploadComponent },
      { path: 'send-informations', component: SendInformationsComponent },
      { path: 'update-data/:id', component: UpdateDataComponent }

    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
