Create Database Aula
Use Aula

Create table Usu�rios
(
Codusuario int not null primary key identity (1,1),
Nome varchar (50)not null,
Usuario varchar (50)not null,
Senha varchar (40)not null,
Funcao varchar (40)not null)

insert into Usu�rios values ('Pedro Pembele','pedro','222','Admin')
insert into Usu�rios values ('Glaucia Pembele','Glaucia','123','Operador')
insert into Usu�rios values ('Castanheira','M�rio','1234','adm')

select*
from Usu�rios
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
