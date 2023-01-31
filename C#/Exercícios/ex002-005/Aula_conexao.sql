Create Database Aula
Use Aula

Create Table Usuario
(CodUsuario int not null primary key identity (1,1), 
Nome_completo varchar (80) not null, 
Usuario varchar (50) not null, 
Senha Varchar (10) not null, 
Função Varchar (20) not null
)

	select*
	from Usuario

insert into Usuario values ('Pedro Pembele','pd34','1234','Adm')

Create Table Produto
(CodProduto int not null primary key identity (1,1), 
Nome varchar (80) not null, 
Tipo varchar (50) not null, 
Preço Varchar (10) not null, 
Estoque Varchar (10) not null,
Data_registo varchar (20) not null
)

	select*
	from Produto

insert into Produto values ('Arroz','Alimento','9500kz','50','28/01/2022')



