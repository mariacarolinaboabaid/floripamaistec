import { Component } from '@angular/core';

@Component({
  selector: 'app-array',
  templateUrl: './array.component.html',
  styleUrls: ['./array.component.css']
})
export class ArrayComponent {

  comidas = ['brigadeiro', 'pipoca', 'sushi', 'lasanha']

  retornaIndex(comida: string){
    let index = this.comidas.indexOf(comida)
    if (index !== -1){
      return index
    }
    else {
      throw new Error('Item não consta no array!')
    }
  }

}
