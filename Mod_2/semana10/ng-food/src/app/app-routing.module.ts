import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CardapioComponent } from './pages/cardapio/cardapio.component';
import { ComidaComponent } from './pages/comida/comida.component';
import { BebidaComponent } from './pages/bebida/bebida.component';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    redirectTo: 'cardapio'
  },
  {
    path: 'cardapio',
    component: CardapioComponent
  },
  {
    path: 'comidas',
    component: ComidaComponent
  },
  {
    path: 'bebidas',
    component: BebidaComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
