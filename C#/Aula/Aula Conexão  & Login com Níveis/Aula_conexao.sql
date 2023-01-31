Create Database Aula
Use Aula

Create table Usuários
(
Codusuario int not null primary key identity (1,1),
Nome varchar (50)not null,
Usuario varchar (50)not null,
Senha varchar (40)not null,
Funcao varchar (40)not null)

insert into Usuários values ('Pedro Pembele','pedro','222','Admin')
insert into Usuários values ('Glaucia Pembele','Glaucia','123','Operador')
insert into Usuários values ('Castanheira','Mário','1234','adm')

select*
from Usuários
delete from Cadastros where CodUsuario = '6'

Create table Produtos 
(Cod_Produto int not null primary key identity (1,1),
Nome_produto varchar (50) not null, 
Tipo_produto varchar (50) not null, 
Preco varchar (20) not null, 
Qtd_Estoque int not null
) 
insert into Produtos values ('Banana','Fruta','2000','12')

select* 
from Produtos
