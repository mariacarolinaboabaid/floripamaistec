import { Injectable } from '@angular/core';
import { ComidaItem } from '../models/comida-item.model';
import { BebidaItem } from '../models/bebida-item.model';
import { COMIDAS_MOCK } from '../mocks/comida.mock';
import { BEBIDAS_MOCK } from '../mocks/bebida.mock';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AppService {
  listaComidas : ComidaItem[] = COMIDAS_MOCK
  listaBebidas: BebidaItem[] = BEBIDAS_MOCK

  constructor(private http: HttpClient) { }

  getComidas(): Observable<ComidaItem[]>{
    return this.http.get<ComidaItem[]>("http://localhost:3000/comidas")
  }

  getBebidas(): Observable<BebidaItem[]>{
    return this.http.get<BebidaItem[]>("http://localhost:3000/bebidas")
  }
}
