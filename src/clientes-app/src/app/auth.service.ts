import { HttpClient, HttpClientModule, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { from, Observable } from 'rxjs';
import { Usuario } from './login/usuario';

import { environment } from '../environments/environment';

import { JwtHelperService} from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  apiURL: string = environment.apiURLBase + "/api/Usuarios/";
  //tokenURL: string = environment.apiURLBase + environment.obterTokenUrl;
  tokenURL: string = environment.apiURLBase + "api/Usuarios/login" 
  clientID: string = environment.clientId;
  clientSecret: string = environment.clientSecret;
  jwtHelper: JwtHelperService = new JwtHelperService();

  constructor(
    private http: HttpClient
  ) { }

  obterToken(){
    const tokenString = localStorage.getItem('access_token');
    if (tokenString) {
      const token = tokenString;//JSON.parse(tokenString).access_token;
      return token;      
    }
    return null;
  }

  encerrarSessao(){
    localStorage.removeItem('access_token');
  }

  getUsuarioAutenticado(){
    const token = this.obterToken();
    if (token) {
      const usuario = this.jwtHelper.decodeToken(token).email;
      return usuario;      
    }
    return null;
  }

  isAutheticated(): boolean{
    const token = this.obterToken();
    console.log("token: "+ token);
    if (token) {
      const expired = this.jwtHelper.isTokenExpired(token);
      return !expired;      
    }
    return false;
  }

  salvar(usuario: Usuario): Observable<any>{
    return this.http.post<any>(this.apiURL, usuario);
  }

  tentarLogar( username: string, password: string): Observable<any>{
    const params = new HttpParams()
                                        .set('email', username)
                                        .set('senha', password);
    const headers = {
      //'Authorization' : 'Basic ' + btoa(`${this.clientID}:${this.clientSecret}`),
      'Content-Type' : 'application/json'
    }
    //return this.http.post<any>(this.tokenURL,params.toString(), { headers });
    return this.http.post<any>(this.tokenURL,JSON.stringify({"email": username,"senha": password}), { headers });
    
    
  }
}
