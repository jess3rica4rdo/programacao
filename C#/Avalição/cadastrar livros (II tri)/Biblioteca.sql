Create Database Biblioteca
Use Biblioteca

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

create Table Livro
(CodLivro int not null primary key identity (1,1), 
NomeAutor varchar (80) not null, 
Titulo varchar (50) not null, 
Editora Varchar (20) not null, 
Edicao Varchar (20) not null,
Endereco varchar (30) not null
)

	select*
	from Livro

insert into Livro values ('Manuel Rui','Quem me dera ser onda','Pedro Manuel','II','Rua 13, Casa nº 3, Nova-vida')



