/* Para que possamos criar um banco de dados que relaciona N serviços e N os, precisamos criar uma tabela adicional (osxservicos) e inserir nela as ids de ambos como chaves estrangeiras */
create database desafio;
create table clientes (Id int NOT NULL PRIMARY KEY, Nome varchar(50), Email varchar(50) NOT NULL UNIQUE, Nascimento datetime, Celular varchar(50), Fixo varchar(50));
create table servicos (Id int NOT NULL PRIMARY KEY, NomeServico varchar(50), ValorFinal float);
create table os (Id int NOT NULL PRIMARY KEY, IdCliente int, DataContratacao datetime, DataExecucao datetime);
create table osxservico (Id int NOT NULL PRIMARY KEY, IdOs int FOREIGN KEY REFERENCES os(Id), IdServico int FOREIGN KEY REFERENCES servicos(Id));

/* Para inserir um cliente, precisamos usar o comando INSERT, explicitando quais parâmetros serão atribuídos - caso não sejam todos */

insert into clientes (Nome, Email) values ('Nome', 'mail@provedor.com');
