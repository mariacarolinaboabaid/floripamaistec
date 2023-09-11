import { Component } from '@angular/core';
import { ValidacaoService } from '../services/validacao.service';

@Component({
  selector: 'app-exercicio',
  templateUrl: './exercicio.component.html',
  styleUrls: ['./exercicio.component.css']
})
export class ExercicioComponent {

  constructor(public validacaoService: ValidacaoService) {}

  enviarDados1(){
    this.validacao()
    console.log('Dados enviados!')
  }

  validacao(){
    console.log('Dados validados!')
  }

  enviarDados2(){
    this.validacaoService.validacao()
    console.log('Dados enviados!')
  }


}
