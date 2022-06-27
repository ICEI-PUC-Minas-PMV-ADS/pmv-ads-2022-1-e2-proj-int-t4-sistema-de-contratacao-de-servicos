const urlBaseProducao = "https://api-contratos-servicos20220514121916.azurewebsites.net/"
const urlBaseDesenvolvimento = "https://localhost:7247/";
const urlBase = urlBaseProducao;

export function chamarGet(endPoint){
  let request = new XMLHttpRequest();
  request.open("GET",urlBase + endPoint,false);
  request.send();
  return request.responseText;
}

export function chamarPost(endPoint, body){
  let request = new XMLHttpRequest();
  request.open("POST",urlBase + endPoint,false);
  request.setRequestHeader("Content-Type", "application/json");
  request.send(body);
  return request.response;
}


export function chamarPost2(endPoint, body){
 return fetch(urlBase + endPoint, {
    method: "POST",
    body: (body),
    headers: {"Content-type": "application/json; charset=UTF-8"}
  });
}

export async function chamarGetParametro(endPoint){
  var bearer = `Bearer ` + obterToken().replaceAll("\"","",);
  return await fetch(urlBase + endPoint, {
     method: "GET",
     headers: {"Authorization":bearer}
   });
 }

function parseJwt (token) {
  var base64Url = token.split('.')[1];
  var base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
  var jsonPayload = decodeURIComponent(window.atob(base64).split('').map(function(c) {
      return '%' + ('00' + c.charCodeAt(0).toString(16)).slice(-2);
  }).join(''));

  return JSON.parse(jsonPayload);
};

function obterToken(){
  const tokenString = localStorage.getItem('access_token');
  if (tokenString) {
    const token = tokenString;//JSON.parse(tokenString).access_token;
    return token;      
  }
  return null;
}

export function encerrarSessao(){
  localStorage.removeItem('access_token');
}

export function getUsuarioAutenticado(){
  const token = obterToken();
  if (token) {
    const usuario = ({"email": parseJwt(token).email,"id": parseJwt(token).nameid})//this.jwtHelper.decodeToken(token).email;
    return usuario;      
  }
  return null;
}

export function isAutheticated() {
  const token = obterToken();
  if (token) {
    let now = new Date().getTime()/1000;
    let dataToken = parseJwt(token).exp;
    const expired = dataToken >= now;
    return !expired;      
  }
  return false;
}




