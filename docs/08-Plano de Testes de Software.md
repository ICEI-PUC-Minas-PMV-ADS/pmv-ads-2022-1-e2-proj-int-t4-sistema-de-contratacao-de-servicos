# Plano de Testes de Software

Requisitos para realização dos testes:<br>
• Site publicado na internet;<br>• Navegador de Internet ;<br>
• Conexão com a internet para acesso à plataforma.


Os testes funcionais a serem realizados no site são descritos a seguir:

|Caso de Teste        |CT-01 - Cadastro de usuários na aplicação, login e recuperação de senha|
|---------------------|----------------------------------------------------------------|
|Requesito atendido   |RF - 001: O site deve possibilitar ao usuário (cliente e fornecedor de serviços) fazer login, se cadastrar ou alterar sua senha.
|Objetivos do Teste   |Verificar o cadastro de usuários na aplicação, login de usuários já cadastrados e a recuperaçao da senha.|
|Passos               |1: Acessar a aplicação;<br>2: Realizar o cadastro (novos usuários);<br>3: Realizar o login (usuários já cadastrados);<br>4: Verificar se o acesso foi permitido desse usuário;<br>5: Realizar a recuperaçao da senha;<br>6: Verificar a validação e realizar o logout|
|Critérios de êxito   |1: Acesso na aplicação via login<br>2: Comunicação correta com o banco de dados;<br>3: Validação dos campos do formulário de cadastro<br>4: êxito na recuperação de senha |

Caso de Teste        |CT-02 - Lista pré-estabelecida de serviços, solicitação de serviços e orçamento|
|---------------------|----------------------------------------------------------------|
|Requisitos atendidos   |RF - 002: O site deve conter uma lista pré-estabelecida de serviços que poderão ser selecionados pelo fornecedor de serviços (como serviço oferecido) e pelo cliente (como serviço desejado);<br> RF - 003: O site deve permitir ao cliente selecionar um serviço (da lista pré-estabelecida) e solicitar seu orçamento, podendo também adicionar informações sobre o serviço requerido
|Objetivos do Teste   |Verificar a interação entre cliente e prestador de serviços por meio da lista pré-estabelecida e das funcionalidades de solicitaçao de serviços e orçamento. |
|Passos               |1: Acessar a aplicação;<br>2: Realizar o cadastro (novos usuários);<br>3: Realizar o login (usuários já cadastrados);<br>4: Acessar a lista pré-estabelecidas de serviços;<br>5: Selecionar na lista quais serviços oferecer para o cliente (prestador de serviços);<br>6: Selecionar na lista o serviço desejado (cliente);<br>7:  Solicitação de orçamento do cliente para o prestador de serviços. |
|Critérios de êxito   |1: Funcionamento correto da lista pré-estabelecida<br>2: funcionamento correto das funcionalidades que permitem a interação entre cliente e prestador de serviços.

Caso de Teste        |CT-03 - Agendamento do serviço escolhido pelo cliente.|
|---------------------|----------------------------------------------------------------|
|Requesito atendido   |RF - 005: O site deve permitir ao cliente o agendamento do serviço escolhido após ter recebido e aprovado o orçamento do mesmo
|Objetivos do Teste   |Verificar a interação entre cliente e prestador de serviços na funcionalidade de agendamento de serviços. |
|Passos               |1: Acessar a aplicação;<br>2: Realizar o cadastro (novos usuários);<br>3: Realizar o login (usuários já cadastrados);<br>4:solicitar o orçamento para o prestador de serviços (cliente);<br>5: Enviar orçamento para o cliente (prestador de serviços);<br>6: Receber o orçamento enviado pelo prestador de serviços (cliente);<br>7: Aprovar o orçamento enviado pelo prestador de serviços(cliente);<br>8: Agendar a realização do serviço. |
|Critérios de êxito   |1: Êxito do cliente e do prestador de serviços no agendamento do serviço.<br>2: funcionamento correto das funcionalidades que permitem a interação e o contato entre cliente e prestador de serviços.

Caso de Teste        |CT-04 - Avaliação do serviço prestado, visualização do conatato e do histórico de avaliações anteriores do prestador de serviços.|
|---------------------|----------------------------------------------------------------|
|Requisitos atendidos   |RF - 008: O site deve permitir ao cliente realizar a avaliação do serviço prestado pelo fornecedor;<br>RF - 010: O site deve permitir ao cliente visualizar o contato e as avaliações referentes aos fornecedores. |
|Passos               |1: Acessar a aplicação;<br>2: Realizar o cadastro (novos usuários);<br>3: Realizar o login (usuários já cadastrados);<br>4: Avaliar o serviço prestado pelo prestador de serviços (cliente);<br>5: Acessar a página de acesso de informações de contato do prestador de serviços;<br>6: Acesso ao histórico de avaliações anteriores do prestador de serviços desejado (cliente).|
|Critérios de êxito   |1: Êxito do cliente ao avaliar um prestador de serviço específico.<br>2:  Êxito do cliente ao procurar as informações de contato do prestador de serviços desejado.<br>3: Êxito do cliente ao conseguir visualizar avaliações anteriores do prestador de serviçods específico.

Caso de Teste        |CT-05 - Envio do orçamento.|
|---------------------|----------------------------------------------------------------|
|Requisitos atendidos   |RF - 004: O site deve permitir ao fornecedor enviar proposta.	                                                       |
|Passos               |1: Acessar a aplicação;<br>2: Realizar o login como fornecedor;<br>3: Acessar a lista de pedidos pendentes de orçamento;<br>4: Realizar o orçamento e enviar.|
|Critérios de êxito   |1: Êxito do fornecedor ao visualizar os pedidos pendentes de orçamentos.<br>2:  Êxito do fornecedor ao enviar o orçamento.

Caso de Teste        |CT-06 - Realização do pagamento do cliente pelo serviço agendado.|
|---------------------|----------------------------------------------------------------|
|Requisitos atendidos   |RF - 007: O site deve permitir ao cliente efetuar o pagamento pelo serviço(s) prestado(s).	                                               |
|Passos               |1: Acessar a aplicação;<br>2: Realizar o login como cliente;<br>3: Acessar a lista de serviços agendados;<br>4: selecionar o serviço desejado;<br>5: efetuar o pagamento.|
|Critérios de êxito   |1: Êxito do cliente ao acessar a lista de serviços agendados.<br>2:  Êxito do cliente efetuar o pagamento.

Caso de Teste        |CT-07 - Realização do pagamento do cliente pelo serviço agendado.|
|---------------------|----------------------------------------------------------------|
|Requisitos atendidos   |RF - 009: O site deve permitir ao fornecedor o recebimento online pelo serviços prestados.		                                               	 |
|Passos               |1: Acessar a aplicação;<br>2: Realizar o login como fornecedor;<br>3: Acessar a lista de serviços realizados;<br>4: Realizar o recebimento do pagamento.|
|Critérios de êxito   |1: Êxito do fornecedor ao acessar a lista de serviços realizados.<br>2:  Êxito do fornecedor receber o pagamento.


# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Enumere quais cenários de testes foram selecionados para teste. Neste tópico o grupo deve detalhar quais funcionalidades avaliadas, o grupo de usuários que foi escolhido para participar do teste e as ferramentas utilizadas.
 