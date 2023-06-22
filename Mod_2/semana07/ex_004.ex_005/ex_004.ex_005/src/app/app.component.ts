import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  formulario: FormGroup
  hidden = true
  message: string = ""

  constructor() {
    this.formulario = new FormGroup({
      'nome': new FormControl('', [Validators.required, Validators.minLength(3)]),
      'email': new FormControl('', [Validators.required, Validators.email]),
      'nomeFilme': new FormControl('', [Validators.required, Validators.minLength(3)]),
      'avaliacao': new FormControl('', [Validators.required, Validators.min(0), Validators.max(10)]),
    })
  }

  onSubmit() {
    if (this.formulario.valid) {
      this.hidden = false
      this.message = `A avaliação do filme ${this.formulario.get('nomeFilme')?.value} foi concluída com sucesso. <br> Obrigada pela sua avaliação!`
    }
  }

  cancelar() {
    this.formulario.get('nome')?.reset()
    this.formulario.get('email')?.reset()
    this.formulario.get('nomeFilme')?.reset()
    this.formulario.get('avaliacao')?.reset()
  }
}
