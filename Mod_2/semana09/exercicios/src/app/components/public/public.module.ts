import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PublicRoutingModule } from './public-routing.module';
import { EsqueciSenhaComponent } from './esqueci-senha/esqueci-senha.component';
import { ContentComponent } from 'src/app/layouts/content/content.component';
import { SignInComponent } from './sign-in/sign-in.component';


@NgModule({
  declarations: [
    ContentComponent,
    SignInComponent,
    EsqueciSenhaComponent
  ],
  exports: [
    ContentComponent,
    SignInComponent,
    EsqueciSenhaComponent
  ],
  imports: [
    CommonModule,
    PublicRoutingModule
  ]
})
export class PublicModule { }
