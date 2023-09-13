import { Component, EventEmitter, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-modal-form',
  templateUrl: './modal-form.component.html',
  styleUrls: ['./modal-form.component.css']
})
export class ModalFormComponent {

  @Output() closeModalComponent: EventEmitter<any> = new EventEmitter();

  formularioAvaliacao: FormGroup

  constructor(private modal: NgbActiveModal){

    this.formularioAvaliacao = new FormGroup(
      {
        'nome': new FormControl('', Validators.required),
        'email': new FormControl('', [Validators.required, Validators.email]),
        'dataNascimento': new FormControl('', Validators.required)
      }
    )
  }

  mensagemCampoInvalido(field: string) {
    return (this.formularioAvaliacao.get(field)?.value === null || this.formularioAvaliacao.get(field)?.value.length === 0) && this.formularioAvaliacao.get(field)?.touched
  }

  onSubmit()
  {
    console.log("Testando!")
  }

  fecharModal(){
    this.closeModalComponent?.emit();
  }


}
