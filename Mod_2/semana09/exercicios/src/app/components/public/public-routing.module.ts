import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SignInComponent } from './sign-in/sign-in.component';
import { EsqueciSenhaComponent } from './esqueci-senha/esqueci-senha.component';
import { ContentComponent } from 'src/app/layouts/content/content.component';
import { FormsModule } from '@angular/forms';

const routes: Routes = [
  {
    path: '', component: ContentComponent,
    children:
      [
        { path: '', component: SignInComponent },
        { path: 'esqueciSenha', component: EsqueciSenhaComponent }
      ]
  }];;

@NgModule({
  imports: [
    RouterModule.forChild(routes)
  ],
  exports: [
    RouterModule,
    FormsModule
  ]
})
export class PublicRoutingModule { }
