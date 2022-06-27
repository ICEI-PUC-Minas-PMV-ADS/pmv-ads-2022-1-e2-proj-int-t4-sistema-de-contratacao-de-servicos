import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from '../auth.guard';
import { LayoutComponent } from '../layout/layout.component';
import { ServicoPrestadoFormComponent } from './servico-prestado-form/servico-prestado-form.component';
import { ServicoPrestadoListaComponent } from './servico-prestado-lista/servico-prestado-lista.component';

const routes: Routes = [
  { path:'servicos-prestado', component: LayoutComponent, canActivate: [AuthGuard], 
  children:[
    { path: 'form', component: ServicoPrestadoFormComponent},
    { path: 'lista', component: ServicoPrestadoListaComponent}  ,
    { path: '', redirectTo: '/servico-prestado/lista', pathMatch: 'full'} 
]}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ServicoPrestadoRoutingModule { }
