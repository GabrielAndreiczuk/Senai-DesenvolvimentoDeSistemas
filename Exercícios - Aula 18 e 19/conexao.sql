create database conexao;
use conexao;

create table Clientes(
	ID int primary key auto_increment,
    Nome varchar(100),
    Email varchar(100)
);

select * from Clientes;
truncate table Clientes;