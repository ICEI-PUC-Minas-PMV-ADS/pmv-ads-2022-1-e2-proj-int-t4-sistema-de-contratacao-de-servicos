import { Component, EventEmitter, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../auth.service';
import { Usuario } from './usuario'

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent  {

  username?: string;
  password?: string;
  mensagemSucesso?: string;
  loginError?: boolean;
  cadastrando?:boolean;
  errors?: String[];

  constructor(
    private router: Router,
    private authService: AuthService
  ) {
    
   }

  onSubmit(){
    if (this.username && this.password) {
      this.authService
                  .tentarLogar(this.username, this.password)
                  .subscribe( response =>{
                    const access_token = JSON.stringify(response.token);
                    localStorage.setItem('access_token',access_token);
                    this.router.navigate(['/home']);
                  }, errorResponse => {
                    this.errors = ['Usuário e/ou senha incorreto(s).']

                  });
    } else {
      this.errors = ['Usuário e/ou senha incorreto(s).']
    }
    
  }

  prepararCadastrar(event: any){
    event.preventDefault();
    this.cadastrando = true;
  }

  cancelaCadastrar(){
    this.cadastrando=false;
  }

  cadastrar(){
    const usuario: Usuario= new Usuario();
    usuario.username = this.username;
    usuario.password = this.password;
    this.authService
          .salvar(usuario)
          .subscribe( reponse =>  {
            this.mensagemSucesso = 'Cadastro realizado com sucesso. Efeue o Login!';
            this.errors = [];
            this.cadastrando = false;
            this.username='';
            this.password='';
          }, errorResponse =>{
            this.mensagemSucesso = '';
            this.errors = errorResponse.error.errors;            
          }     
          )
  }

}
