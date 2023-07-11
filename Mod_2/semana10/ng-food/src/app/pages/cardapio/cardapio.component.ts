import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { CardapioItem } from 'src/app/shared/models/cardapio-item.model';

@Component({
  selector: 'nfd-cardapio',
  templateUrl: './cardapio.component.html',
  styleUrls: ['./cardapio.component.css']
})
export class CardapioComponent {

  infoApresentacao = {
    titulo: 'NgFood',
    descricao: 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus eius dignissimos aliquam velit esse itaque, nobis odio quam eos! Praesentium esse enim aspernatur dicta harum molestiae mollitia dolorum? Magni, itaque.',
    tituloBotao: 'Cardápio'
  }

  itensCardapio: CardapioItem[] = [
    {
      titulo: 'Comidas',
      urlImagem: '../../../assets/comidas.jpg',
      path: 'comidas'
    },
    {
      titulo: 'Bebidas',
      urlImagem: '../../../assets/bebidas.jpg',
      path: 'bebidas'
    }
  ]

  constructor(private router: Router){}

  navegarParaPagina(item: CardapioItem) {
    console.log(item)
    this.router.navigate([item.path])
  }
}
