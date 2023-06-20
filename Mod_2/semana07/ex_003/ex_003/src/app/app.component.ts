import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  primeiroNumero : string  = ""
  segundoNumero : string = ""
  operacoes : string = ""
  resultado : number = 0
  primeiroNumeroNumber : number = 0
  segundoNumeroNumber : number = 0
  hidden = true

  calcular(){
    this.primeiroNumeroNumber = parseInt(this.primeiroNumero)
    this.segundoNumeroNumber = parseInt(this.segundoNumero)

    if (this.operacoes == "somar") {
      this.resultado = this.primeiroNumeroNumber + this.segundoNumeroNumber
    }
    else if (this.operacoes == "subtrair"){
      this.resultado = this.primeiroNumeroNumber - this.segundoNumeroNumber
    }
    else if (this.operacoes == "multiplicar"){
      this.resultado = this.primeiroNumeroNumber * this.segundoNumeroNumber
    }
    else if (this.operacoes == "dividir"){
      this.resultado = this.primeiroNumeroNumber / this.segundoNumeroNumber
    }
    this.hidden = false
    console.log(this.resultado)
  }

  limpar(){
    this.primeiroNumero = ""
    this.segundoNumero = ""
    this.operacoes = ""
    this.resultado  = 0
    this.hidden = true
  }
}
