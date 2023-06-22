import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IFilme } from '../interface/IFilme';
import { environment } from 'src/environments/environment.development';
import { ReturnStatement } from '@angular/compiler';

@Injectable({
  providedIn: 'root'
})
export class FilmesService {

  constructor(private httpClient: HttpClient) { }

  buscarFilmes() {
    return this.httpClient.get<IFilme[]>(`${environment.mockUrl}/filmes/get-all`)
  }

  buscarFilmePopular(filmesArray: IFilme[]) {
    
    let filmePopular: IFilme

    return filmesArray.reduce(function (filmeAnterior, filmeAtual) {
      return filmeAnterior.nota > filmeAtual.nota ? filmeAnterior : filmeAtual
    })
  }

  buscarTopTres(filmesArray: IFilme[]) {
    let topTres : IFilme[] = []
    let filmesArrayCopia : IFilme[] = filmesArray
    for (let index = 0; index  < 3;  index++){
      topTres.push(this.buscarFilmePopular(filmesArrayCopia))
      filmesArrayCopia.splice(filmesArrayCopia.indexOf(topTres[index], 1))
    }
    return topTres
  }
}
