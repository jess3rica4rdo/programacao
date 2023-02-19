Create Database Bercario
Use Bercario

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

Create Table Bebe
(CodBebe int not null primary key identity (1,1), 
NomeBebe varchar (100) not null, 
Data_nascimento varchar (100) not null, 
Peso Varchar (100) not null, 
Altura Varchar (100) not null,
Sexo varchar (100) not null,
Mae varchar (100) not null,
Medico varchar (100) not null
)

	select*
	from Bebe

insert into Bebe values ('Pedro Pembele','27/01/2023','1kg','60cm','Masculino','Delfina, Capolo rua 3 casa 15, Tel: 925555098, Idade: 30', 'Numero de ordem: 2004, Daniel Pedro, Tel: 992500069, Parteiro')



