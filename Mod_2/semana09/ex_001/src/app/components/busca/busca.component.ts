import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-busca',
  templateUrl: './busca.component.html',
  styleUrls: ['./busca.component.css']
})
export class BuscaComponent {
  
  busca: string = ''

  @Output()
  teclaDigitada = new EventEmitter<any> ()

  mensagemInput(event: KeyboardEvent) {
    this.teclaDigitada.emit(event.key)
  }
}
