import { chamarPost2} from './api.js';

function login() {
  //event.preventDefault();
 
  var email = document.getElementById('email').value;
  var password = document.getElementById('password').value;
  
  if (email && password) {
   chamarPost2('api/Usuarios/login', JSON.stringify({"email": email,"senha": password}))
   .then(response => {
    if (response.status >= 200 && response.status < 300)
      return response.json();
    else throw response.status + " " + response.statusText;
   }) 
   .then(data => {
    const access_token = JSON.stringify(data.token);
    localStorage.setItem('access_token',access_token);
    document.getElementById('erroMsg').style.display = 'none';
    window.location.href="orcamento.html";
   })
   .catch(err => {
    document.getElementById('erroMsg').style.display = 'block';
    console.log(err)
   });
  }
  else {
    document.getElementById('erroMsg').style.display = 'block';
  }
  return true;
}

function cadastrar() {
  //event.preventDefault();
 
  var nome = document.getElementById('nome').value;
  var email = document.getElementById('email').value;
  var cpf = document.getElementById('cpf').value;
  var telefone = document.getElementById('telefone').value;
  var cep = document.getElementById('cep').value;
  var logradouro = document.getElementById('logradouro').value;
  var numero = document.getElementById('numero').value;
  var bairro = document.getElementById('bairro').value;
  var cidade = document.getElementById('cidade').value;
  var uf = document.getElementById('uf').value;
  var senha = document.getElementById('senha').value;
  var senha2 = document.getElementById('senha2').value;
  var tipo = document.querySelector('input[name="inlineRadioOptions"]:checked').value;
  if (senha != senha2){
    console.log("senha diferente");
    return false;
  }
  if (tipo && email && senha && senha2 && senha === senha2) {
    console.log("entrou");
   var usuarioJson = JSON.stringify({"nome":nome,"email":email,"cpf":cpf,"telefone":telefone,"cep":cep,
   "logradouro":logradouro,"numero":numero,"bairro":bairro,"cidade":cidade,
   "uf":uf,"senha":senha,"tipo":tipo,});
   chamarPost2('api/Usuarios/cadastrar', usuarioJson)
   .then(response => {
    if (response.status >= 200 && response.status < 300)
      return response.json();
    else throw response.status + " " + response.statusText;
   }) 
   .then(data => {
    const usuario = data;
    console.log(usuario);
    //localStorage.setItem('access_token',access_token);
    //document.getElementById('erroMsg').style.display = 'none';
    alert("Usuario cadastrado com sucesso")
    window.location.href="login.html";
   })
   .catch(err => {
    //.getElementById('erroMsg').style.display = 'block';
    console.log(err)
   });
  }
  else {
    console.log("erro");
    //document.getElementById('erroMsg').style.display = 'block';
  }
  return true;
}

let telaLogin = document.getElementById("submit");
if (telaLogin) {
  telaLogin.addEventListener ("click", login, false);
}

let telaCadastro = document.getElementById("submitRegistro");
if (telaCadastro) {
  telaCadastro.addEventListener ("click", cadastrar, false);
}
