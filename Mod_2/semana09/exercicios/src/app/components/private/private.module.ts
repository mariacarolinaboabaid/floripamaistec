import { NgModule} from '@angular/core';
import { CommonModule } from '@angular/common';



import { PrivateRoutingModule } from './private-routing.module';
import { PrivateComponent } from 'src/app/layouts/private/private.component';
import { HomeComponent } from './home/home.component';
import { MaisUmaPaginaComponent } from './mais-uma-pagina/mais-uma-pagina.component';
import { OutraPaginaComponent } from './outra-pagina/outra-pagina.component';
import { HeaderComponent } from '../shared/header/header.component';



@NgModule({
  declarations: [
    PrivateComponent,
    HomeComponent,
    OutraPaginaComponent,
    MaisUmaPaginaComponent,
    HeaderComponent
  ],
  exports: [
    PrivateComponent,
    HomeComponent,
    OutraPaginaComponent,
    MaisUmaPaginaComponent,
    HeaderComponent
  ],
  imports: [
    CommonModule,
    PrivateRoutingModule
  ]
})
export class PrivateModule { }
