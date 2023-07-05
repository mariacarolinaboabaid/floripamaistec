import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PrivateComponent } from 'src/app/layouts/private/private.component';
import { HomeComponent } from './home/home.component';
import { MaisUmaPaginaComponent } from './mais-uma-pagina/mais-uma-pagina.component';
import { OutraPaginaComponent } from './outra-pagina/outra-pagina.component';

const routes: Routes = [
  {
    path: '', component: PrivateComponent,
    children:
    [
      {path: 'home', component: HomeComponent},
      {path: 'outraPagina', component: OutraPaginaComponent},
      {path: 'maisUmaPagina', component: MaisUmaPaginaComponent},
    ]}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PrivateRoutingModule { }
