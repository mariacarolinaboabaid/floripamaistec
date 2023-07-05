import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/private/home/home.component';
import { OutraPaginaComponent } from './components/private/outra-pagina/outra-pagina.component';
import { MaisUmaPaginaComponent } from './components/private/mais-uma-pagina/mais-uma-pagina.component';
import { FullComponent } from './layouts/full/full.component';
import { PrivateComponent } from './layouts/private/private.component';
import { NotFoundComponent } from './components/not-found/not-found.component';

const routes: Routes = [
  {
    path: '', component: FullComponent,
    children:
      [
        {
          path: '',
          loadChildren: () => import('./components/public/public.module').then(m => m.PublicModule)
        },
        {
          path: 'private',
          loadChildren: () => import('./components/private/private.module').then(m => m.PrivateModule)
        },
        { path: '**', component: NotFoundComponent }

      ]
  },


];

// 

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
