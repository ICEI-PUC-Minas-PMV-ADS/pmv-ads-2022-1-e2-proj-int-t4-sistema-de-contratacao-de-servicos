var usuarios = [
  {"login": "demo", "senha": "demo123"},
  {"login": "tecnico", "senha": "tecnico123"},
  {"login": "supervisor", "senha": "supervisor123"},
  {"login": "gerente", "senha": "gerente123"},
];

function Login() {
  var usuario = document.getElementById('usuario').value;
  var password = document.getElementById('password').value;
  for (var u in usuarios) {
      var us = usuarios[u];
      if (us.login === usuario && us.senha === password) {
        document.getElementById('erroMsg').style.display = 'none';
        setUsuarioSession(usuario);
        return true;
      }
  }
  document.getElementById('erroMsg').style.display = 'block';
  return false;
}

function setUsuarioSession(usuario) {
  console.log('teste: '+ usuario);
  sessionStorage.setItem('usuario', usuario);
}

/////########

function conectarBanco(url){
  let request = new XMLHttpRequest();
  request.open("GET",url,false);
  request.send();
  return request.responseText;
}


function main(){
  data = conectarBanco("https://api-contratos-servicos20220514121916.azurewebsites.net/api/TipoServicos");
  clientes = JSON.parse(data);
  console.log(clientes);
  /*
  let tabela = document.getElementById("tabela");
  clientes.forEach(element => {
    let linha  = criarLinha(element);
    tabela.appendChild(linha);
  });
  */
  // para cada usuario
}

function criarLinha(cliente){
  linha = document.createElement("tr");
  tdID = document.createElement("td");
  tdNome = document.createElement("td");
  tdID.innerHtml = cliente.cpf;
  tdNome.innerHtml = cliente.telefone;

  linha.appendChild(tdID);
  linha.appendChild(tdNome);

  return linha;
}

main();
 