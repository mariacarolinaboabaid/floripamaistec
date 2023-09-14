import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment.development';
import { UsuarioModelList } from '../models/UsuarioModel';

@Injectable({
  providedIn: 'root'
})
export class ListUserService {

  constructor(private httpClient: HttpClient) { }

  listUsers(){
    return this.httpClient.get<UsuarioModelList[]>(`${environment.dbUrl}/api/Ficha`)
  }
}
