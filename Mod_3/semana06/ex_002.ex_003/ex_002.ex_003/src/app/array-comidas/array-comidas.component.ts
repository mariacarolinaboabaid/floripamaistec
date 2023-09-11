import { COMPILER_OPTIONS, Component } from '@angular/core';

@Component({
  selector: 'app-array-comidas',
  templateUrl: './array-comidas.component.html',
  styleUrls: ['./array-comidas.component.css']
})
export class ArrayComidasComponent {

  comidas = ['torta de morango', 'brigadeiro', 'batata doce']
 

  addStringInicio(comida: string){
    this.comidas.unshift(comida)
    return this.comidas[0];
  };

  arrayTamanhoMaior(comida: string){
    this.comidas.push(comida)
    return this.comidas.length;
  };

  arrayTamanhoMenor(comida: string){
    let index = this.comidas.indexOf(comida)
    this.comidas.splice(index, 1)
    return this.comidas.length;
  }

}
