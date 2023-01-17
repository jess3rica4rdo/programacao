Create Database Livraria
use Livraria 

create Table Cliente 
(Cod_Cliente int not null primary key identity (1,1),
Nome_Cliente varchar (70) not null,
Endereço varchar (70) not null,
Contacto int not null,
Cod_Compra int not null foreign key references Compra(Cod_Compra))

             
	  insert into Cliente Values ('Jessé','Talatona','992500069','1')
      insert into Cliente Values ('Leo','Mutamba','912500069','2')
      insert into Cliente Values ('Bombito','Zango','912500069','2')

create table Compra
(Cod_Compra int not null primary key identity (1,1),
Data_Compra date not null,
Quantidade int not null,
Cod_Livro int not null foreign key references Livro(Cod_Livro))
       
	  insert into Compra Values ('2022-11-20','2','1')
      insert into Compra Values ('2022-11-21','3','2')
      insert into Compra Values ('2022-11-23','1','3')

Create Table Editora 
(Cod_Editora int not null primary key identity (1,1),
Endereço varchar (70) not null,
Telefone int not null,
Gerente varchar (70) not null)
      
	  insert into Editora Values ('Talatona','992500069','Evandro')
      insert into Editora Values ('Mutamba','912500069','Andre')
      insert into Editora Values ('Zango','912500069','Rui')

create Table Livro 
(Cod_Livro int not null primary key identity (1,1),
Autor varchar (50) not null,
Título varchar (50) not null,
Estoque int not null,
Cod_Editora int not null foreign key references Editora(Cod_Editora))
    
	  insert into Livro Values ('jessen','quem me dera ser onda','20','1')
      insert into Livro Values ('fernando','um bom saber','12','2')
      insert into Livro Values ('nelson','O livro de histórias','15','3')


	  alter table Cliente add Sexo varchar (1) not null


	  select Nome_Cliente as Usuario, Endereço, Cod_Compra
	  from Cliente











