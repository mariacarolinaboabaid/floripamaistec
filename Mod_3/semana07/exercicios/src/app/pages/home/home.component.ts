import { Component, TemplateRef, ViewChild } from '@angular/core';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { UsuarioModelList } from 'src/app/shared/models/UsuarioModel';
import { ListUserService } from 'src/app/shared/services/list-user.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  listaUsuarios: UsuarioModelList[] = []

  @ViewChild('modalFormulario', {static: true}) modalFormulario: TemplateRef<any> | undefined;
  modalUploadRef: NgbModalRef | undefined;

  constructor(private modalService: NgbModal, private listUser: ListUserService) {}

  ngOnInit(): void {
    this.listUser.listUsers()
    .subscribe((result) => {
      console.log(result)
      this.listaUsuarios = result;
    })


  }

  openModalFormularioHome(){
    this.modalUploadRef = this.modalService.open(this.modalFormulario)
  }

  closeModalFormularioHome() {
    this.modalUploadRef?.close();
    }

}

