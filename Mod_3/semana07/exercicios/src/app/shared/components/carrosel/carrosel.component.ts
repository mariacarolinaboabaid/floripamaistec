import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-carrosel',
  templateUrl: './carrosel.component.html',
  styleUrls: ['./carrosel.component.css']
})
export class CarroselComponent {

  @Output() openModalFormulario: EventEmitter<any> = new EventEmitter();

  abrirModal(){
    this.openModalFormulario?.emit();
  }
}
