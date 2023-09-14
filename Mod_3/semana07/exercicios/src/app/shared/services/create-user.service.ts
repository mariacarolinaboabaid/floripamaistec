import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment.development';
import { UsuarioModelCreate } from '../models/UsuarioModel';

@Injectable({
  providedIn: 'root'
})
export class CreateUserService {

  constructor(private httpClient: HttpClient) { }

  createUser(postData: UsuarioModelCreate){
    return this.httpClient.post(`${environment.dbUrl}/api/Ficha`, postData)
  }
}
