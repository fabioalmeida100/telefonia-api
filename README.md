# Telefonia
Api para consulta de planos de telefonia desenvolvida em Web Api com C# e .Net Core e Entity Framework Core

Requisitos:

* Banco de dados: MySQL 8.0

* IIS

# Sobre

A API está usando Swagger para documentar os endpoint de cada recurso de consulta que pode ser feito. Como recursos interno foi utilizado o Entity Framework Core com mapemanento por Fluent API. Um repositorio genérico foi construído sobre a camada de acesso a dados e o mesmo foi estendido para implementação de algumas consulta específicas.

# Como montar o ambiente para teste

Na pasta:

/Telefonia/Db temos dois script:

* "script_create.sql" --> Deve ser usado para criar a estrutura de tabelas do banco

* "script_inserts.sql" --> Deve ser usado para dar carga inicial no banco, pois existem tabelas de relacionamento que precisam estar com dados previamente (exemplo: tabela com os DDD e as tabelas com as operadoras).

No arquivo "appsettings.json" temos a string de conexão que está esperando um banco de dados com nome "telefonia". Veja abaixo:

*"MySqlConnectionString": "Server=localhost;DataBase=telefonia;Uid=root;Pwd=root"*

Alterar o nome do banco e dos dados de acesso ao servidor conforme sua configuração.

# Os Endpoint

Na pasta principal do projeto deixei um arquivo exportado do Postman em que já está preparado o ambiente para teste.

Arquivo: **RESTful API Telefonia.postman_collection.json**

O único ajuste necessário para rodar as chamadas no Postman será o variável de ambiente **{{baseUrl}}** em que deverá ser colocado a url do seu servidor. Exemplo: https://localhost:44307/

# Lista dos endpoint

* GET :/api/Plano/listarplanos

Lista todos os planos.

* POST: /api/Plano/cadastrar

Cadastra um novo plano. Importante: é esperado um objeto PlanoVO (veja documentação com exemplo da request no Swagger).

* GET: /api/Plano/codigo/{codigoPlano}/{ddd}

Obtém um plano através do código e DDD.

* GET: /api/Plano/tipo/{tipo}/{ddd}

Obtém um ou mais planos através do tipo do plano e DDD.

* GET: /api/Plano/operadora/{operadora}/{ddd}

Obtém um ou mais planos através da operadora do plano e DDD.

* PUT: /api/Plano/atualizar

Cadastra um plano existente considerando o código do plano. Importante: é esperado um objeto PlanoVO (veja documentação com exemplo da request no Swagger).

* DELETE: /api/Plano/excluir/{codigoPlano}

Exclui um plano através do código do plano.
