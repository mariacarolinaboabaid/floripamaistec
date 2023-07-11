import { Component, OnInit } from '@angular/core';
import { BEBIDAS_MOCK } from 'src/app/shared/mocks/bebida.mock';
import { BebidaItem } from 'src/app/shared/models/bebida-item.model';
import { AppService } from 'src/app/shared/services/app.service';

@Component({
  selector: 'nfd-bebida',
  templateUrl: './bebida.component.html',
  styleUrls: ['./bebida.component.css']
})
export class BebidaComponent implements OnInit {

  bebidaLista: BebidaItem[] = []
  constructor (private bebidaService: AppService) {}
  
  ngOnInit(): void {
    this.bebidaService.getComidas().subscribe((result) => {
      this.bebidaLista = result;
    })}

  
}
