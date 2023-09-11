import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ValidacaoService {

  constructor() { }

  validacao(){
    console.log('Dados validados!')
  }
}
