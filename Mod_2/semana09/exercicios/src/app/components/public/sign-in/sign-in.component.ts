import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})

export class SignInComponent {

  emailUsuario: string = ''

  constructor(private router: Router) {}

  onSubmit() {
    console.log(this.emailUsuario)
    this.router.navigate(['/private/home'])
  }

}
