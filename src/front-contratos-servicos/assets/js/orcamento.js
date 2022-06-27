import { chamarGetParametro, chamarPost2, getUsuarioAutenticado} from './api.js';

var listaRegistros;

function carregarDataTable(){
  const tbody = document.getElementById('listaRegistrosBody')
  if(tbody){
    var data = listaRegistros;
    console.log("listaRegistros");
    console.log(listaRegistros);
    data = data
        .sort( (a, b) => {
            return a.id > b.id ? -1 : 1
        })
        .map( pedido => {
            let serv = descricaoServico(pedido.tipoServico);
            var textArray = [
              'Pendente de Aprovação',
              'Aprovado',
              'Em Execucao'
          ];
          var servStatus = Math.floor(Math.random()*textArray.length);
            return `<tr>
                    <td>${serv}</td>
                    <td>${pedido.data}</td>
                    <td>${pedido.descricao}</td>                    
                    <td>${textArray[servStatus]}</td>
                    
                </tr>`
        } )
    tbody.innerHTML = data.join('')
  }
}
function descricaoServico(id){
  var servico;
  switch (id) {
    case "1":   
      servico = "Montagem de Móveis";
      break;
    case "2":	
      servico = "Limpeza de Ar-Condicionado";
      break;
    case "3":	
      servico = "Instalação";
      break;
    case "4":	
      servico = "Limpeza Padrão";
      break;
    case "5":	
      servico = "Limpeza Pesada";
      break;
    case "6":	
      servico = "Limpeza pós-obra";
      break;
    case "7":	
      servico = "Passar Roupas";
      break;
    case "8":	
      servico = "Lavagem a Seco";
      break;
    case "9":	
      servico = "Dedetização";
      break;
  }
  return servico;
}


function buscarListaOrcamento() {
  var usuarioLogado = getUsuarioAutenticado();
  chamarGetParametro(`api/Pedidos/usuario/` + usuarioLogado.id)
  .then(response => {
  if (response.status >= 200 && response.status < 300)
    return response.json();
  else throw response.status + " " + response.statusText;
  }) 
  .then(data => {
    listaRegistros = data;
    carregarDataTable();
  
  })
  .catch(err => {
  //document.getElementById('erroMsg').style.display = 'block';
  console.log(err)
  });
}

function carregarTipoSercivo() {
  console.log("entrou");
  chamarGetParametro("api/TipoServicos")
  .then(response => {
  if (response.status >= 200 && response.status < 300)
    return response.json();
  else throw response.status + " " + response.statusText;
  }) 
  .then(data => {
    let lista = data;
    const select = document.getElementById('tipoServico')
    if(select){
      limpaCombo();
      var index=0;
      var opt0 = document.createElement("option");
              opt0.value = "0";
              opt0.text = "";
              select.add(opt0, select.options[index]);
      index++;
      lista = lista
          .sort( (a, b) => {
              return a.om < b.om ? -1 : 1
          })
          .map( tpServico => {
              var opt1 = document.createElement("option");
              opt1.value = tpServico.id;
              opt1.text = tpServico.descricaoServico;
              select.add(opt1, select.options[index]);
              index++;
              //return `<option value="${tpServico.om}"><strong>${tpServico.om}</strong></option>`
          } )
    }
  })
  .catch(err => {
  //document.getElementById('erroMsg').style.display = 'block';
  console.log(err)
  return null;
  });
  return null;
}

function limpaCombo(){
  const select = document.getElementById('tipoServico')
  console.log("tamanho combo + "+ select.length);
  for(var i = select.length-1;  i >= 0 ; i--) {
      select.remove(i);
      console.log("removeu " + i); 
  }
}

function perguntarSeDeleta(id){
  if(confirm('Quer deletar o registro de id '+id)){
      console.log("deletou");
  }
}

function visualizar(pagina) {
  event.preventDefault();
  document.body.setAttribute('page',pagina);
}

$(document).ready( function () {
  $('#dataTable').DataTable();
} );

function submeter(e){
  e.preventDefault()
  console.log("submit")
}


function addEventos(){
  
  buscarListaOrcamento();

  console.log("passou");
  document.getElementById("btnCadastro").addEventListener("click", function(event) {
    visualizar('cadastro');
    carregarTipoSercivo();
  })

  document.getElementById("voltarLista").addEventListener("click", function(event) {
    visualizar('lista');
    buscarListaOrcamento();
  })

  el = document.querySelector(".desaprovar").addEventListener("click", function(event) {
    alert(this.id);
  })
}

window.addEventListener('load', addEventos);