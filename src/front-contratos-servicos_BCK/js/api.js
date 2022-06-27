const urlBaseProducao = "https://api-contratos-servicos20220514121916.azurewebsites.net/"
const urlBaseDesenvolvimento = "https://localhost:7247/";
const urlBase = urlBaseDesenvolvimento;

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




