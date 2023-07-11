import { Component, OnInit } from '@angular/core';
import { COMIDAS_MOCK } from 'src/app/shared/mocks/comida.mock';
import { ComidaItem } from 'src/app/shared/models/comida-item.model';
import { AppService } from 'src/app/shared/services/app.service';

@Component({
  selector: 'nfd-comida',
  templateUrl: './comida.component.html',
  styleUrls: ['./comida.component.css']
})
export class ComidaComponent implements OnInit {

  comidaLista: ComidaItem[] = []

  constructor(private comidaService: AppService) { }

  ngOnInit(): void {
    this.comidaService.getComidas().subscribe((result) => {
      this.comidaLista = result;
    })}
}