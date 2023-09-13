import { Component, TemplateRef, ViewChild } from '@angular/core';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  @ViewChild('modalFormulario', {static: true}) modalFormulario: TemplateRef<any> | undefined;
  modalUploadRef: NgbModalRef | undefined;

  constructor(private modalService: NgbModal) {}

  openModalFormularioHome(){
    this.modalUploadRef = this.modalService.open(this.modalFormulario)
  }

  closeModalFormularioHome() {
    this.modalUploadRef?.close();
    }

}

