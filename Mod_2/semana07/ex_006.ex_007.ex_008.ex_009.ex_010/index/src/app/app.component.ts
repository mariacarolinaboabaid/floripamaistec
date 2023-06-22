import { Component } from '@angular/core';
import { IFilme } from './interface/IFilme';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { environment } from 'src/environments/environment.development';
import { FilmesService } from './services/filmes.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  filmes: IFilme[] = []
  carregando = false
  filmeAtual: IFilme | null = null
  filmesTopTres : IFilme[] | null = null
  indiceFilme = 0

  constructor(private filmesService: FilmesService) { 
    this.filmesService.buscarFilmes()
      .subscribe({
        next: resposta => {
          this.filmes = resposta,
          this.carregando = false
          this.filmesTopTres = this.filmesService.buscarTopTres(resposta)
          this.filmeAtual = this.filmesTopTres[0]
        },
        error: (erro: HttpErrorResponse) => console.log("Houve um erro", erro),
      })
  }

  buscarFilmes() {
    this.carregando = true
    this.filmesService.buscarFilmes()
      .subscribe({
        next: resposta => {
          this.filmes = resposta,
          this.carregando = false
        },
        error: (erro: HttpErrorResponse) => console.log("Houve um erro", erro),
      })
  }

  filmeBemAvaliado(){
    const resultado = this.filmesService.buscarFilmePopular(this.filmes)
    console.log(resultado)
  }

  proximo (){
    this.indiceFilme ++
    if (this.filmesTopTres !== null){
      this.filmeAtual = this.filmesTopTres[this.indiceFilme]
    }
    
  }
  
  anterior (){
    this.indiceFilme --
    if (this.filmesTopTres !== null){
      this.filmeAtual = this.filmesTopTres[this.indiceFilme]
    }
  }
}


