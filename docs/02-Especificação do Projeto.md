# Especificações do Projeto

A especificação do projeto e os detalhes mais importantes a serem abordados nesta aplicação foram definidas com a participação de clientes e prestadores de serviços onde a necessidade de executar um reparo especifico com qualidade, preço justo e realizado por profissionais qualificados e capacitados, podendo destacar: instalações elétricas, hidráulicas, manutenções de eletrodomésticos, montagem de moveis entre outras. Para auxiliar na intermediação da mão de obra e execução desses serviços necessita-se a realização do desenvolvimento de uma que plataforma que intermedia os valores da mão de obra, formas de pagamento, data, horário e local entre os usuários do sistema. A especificação do projeto foi levantada a partir das experiencias de personas e histórias dos usuários.   

## Personas
As personas que ajudaram na criação do processo de entendimento do problema são apresentadas que se seguem. 

##1 Nome: Carloos Alberto Silva
Idade: 65 anos
Ocupação: Aposentado
Aplicativos: Facebook, Instagram, WhatsApp
Motivações: Ter um reparo com eficiência e qualidade nas instalações hidráulicas de sua residência por um preço justo.
Frustações: Problema na instalação hidráulica que resulta em vazamento de água. 
Hobbies, Historias: Viajar, Dançar forró (pé de serra).

#2 Nome: José Carlos
Idade: 25 anos
Ocupação: Bombeiro hidráulico e Eletricista.
Aplicativos: Facebook, Instagram, WhatsApp
Motivações: Prestar serviços com qualidade, Adquirir novos Clientes e novas experiências, garantia de recebimento pelo serviço prestado. 
Frustações:Dificuldade em captar novos clientes para seu negócio, não recebimento pelo serviço prestado
Hobbies, Historias: Ir ao cinema, ajudar uma ONG.

#3 Nome: Rafael Silva 
Idade: 49 anos
Ocupação: Administrador do sistema
Aplicativos: Telegram, Facebook, Instagram, MYSQLservar, Visual code, .NET, 
Motivações: Administrar o sistema fazer correções de bugs para garantir a qualidade do sistema cadastrar as informações e gerenciá-las. 
Frustações: A não funcionalidade do sistema. 
Hobbies, Historias: Fazer trilha, Tocar violão. 

#4 Nome: Ana Clara 
Idade: 40 anos
Ocupação: Dona de casa
Aplicativos: WhatsApp 
Motivações: Montagem da nova estante, rapidez e qualidade e bom acabamento
Frustações: Não conseguir bom montador dentro do curto espaço de tempo. 
Hobbies, Historias: Ver series, Se divertir com a família. 

#5 Nome: André Araújo
Idade: 35 anos
Ocupação: Montador de moveis
Aplicativos: WhatsApp, Facebook ,Instagram
Motivações: Prestar serviços com qualidade, Adquirir novos Clientes e novas experiências, garantia de recebimento pelo serviço prestado.
Frustações: Dificuldade em captar novos clientes para seu negócio, não recebimento pelo serviço prestado
Hobbies, Historias: curtir com a família, viajar, Fazer exercícios físicos na acadêmica

#6 Nome: Julia Maria 
Idade: 42 anos
Ocupação: Advogada
Aplicativos: WhatsApp, Facebook, Instagram 
Motivações: Babá com boas recomendações, sua filha bem cuidada enquanto realiza seus compromissos. 
Frustações: Não poder comparecer ao compromisso no horário marcado
Hobbies, Historias: Passeios com a família, Caminhadas

#7 Nome: Marcia Oliveira 
Idade: 28 anos
Ocupação: Baba 
Aplicativos: WhatsApp, Facebook, Instagram 
Motivações: Prestar um bom atendimento aos clientes. 
Frustações: Não ter uma boa reputação para os serviços prestados. 
Hobbies, Historias: Ler livros, Serviços Voluntários. 


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
