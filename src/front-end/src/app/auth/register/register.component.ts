import { Component, OnInit } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { UsuarioLogin } from '../usario';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  formGroup = new FormGroup({
    type: new FormControl('', [Validators.required]),
    email: new FormControl('', [Validators.email]),
    name: new FormControl('', [Validators.required, Validators.minLength(3)]),
    password: new FormControl('', [Validators.required])
  })
  constructor(
    private router: Router,
    private auth: AngularFireAuth,
    private http: HttpClient) { }

  ngOnInit(): void {
  }

  authUser(): void {

    let usuario: UsuarioLogin = new UsuarioLogin();
    usuario.email = this.formGroup.get('email')?.value;    
    usuario.nome = this.formGroup.get('name')?.value;

    this.http.post<UsuarioLogin>(`https://api-contratos-servicos20220514121916.azurewebsites.net/api/usuarios/cadastrar`, usuario)
    .subscribe( response => {
    }, errorResponse =>{
    }
    )  ;
    this.auth.createUserWithEmailAndPassword(this.formGroup.get('email')?.value, this.formGroup.get('password')?.value)
      .then(data => {
        this.router.navigateByUrl('/auth/login');
      })
      .catch(err => console.error(err))
  }

}
