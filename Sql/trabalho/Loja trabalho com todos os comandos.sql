Create Database Loja
use Loja
------------------------------------Criação das tabelas---------------------------------~--

Create table Produto
(Cod_Produto int not null primary key identity (1,1),
Nome_Produto varchar (50) not null,
Preço decimal (18) not null,
Quantidade int not null,
Data_registo date not null,
Cod_Fornecedor int not null foreign key references Fornecedor(Cod_Fornecedor))
        
      insert into Produto values ('Smartpone','9000','10','2022-10-31','1')
      insert into Produto values ('Auricular','5000','10','2022-09-15','2')
      insert into Produto values ('Computador','12000','10','2022-07-16','4')
      insert into Produto values ('Auricular','1500','15','2022-10-21','2')
      insert into Produto values ('SmarTV','250000','09','2022-11-01','3')
      insert into Produto values ('Disco duro','50000','14','2022-11-03','2')
      insert into Produto values ('Smartwatch','90000','5','2022-11-10','4')
      insert into Produto values ('Capa de celular','2500','30','2022-11-15','1')
      insert into Produto values ('Carregador de celular','5000','2022-11-15','1')
      insert into Produto values ('Carregador de Computador','10000','2022-11-20','3')
	   
  Select* 
  From Produto

    Select* 
  From Cliente



Create Table Cliente 
(Cod_Cliente int not null primary key identity (1,1),
Nome_Cliente varchar (70) not null,
Idade int not null,
Morada varchar (70) not null,
Sexo varchar (1) not null,
Contacto int not null)
       
	  insert into Cliente Values ('Jessé','15','Talatona','M','992500069')
      insert into Cliente Values ('Leo','22','Mutamba','M','912500069')
      insert into Cliente Values ('Bombito','21','Zango','M','912500069')
      insert into Cliente Values ('Ricardo','16','Nova-Vida','M','939078779')
      insert into Cliente Values ('Jessé','17','Talatona','M','992500069')
      insert into Cliente Values ('Adelaide','40','Camama','F','997078777')
      insert into Cliente Values ('Rissara','37','Viana','F','942855684')
      insert into Cliente Values ('Daniel','14','Nova-Vida','M','939098776')
      insert into Cliente Values ('Janeth','18','Golf','F','945477677')
      insert into Cliente Values ('Ivanilson','17','Filda','M','998776544')

  Select* 
  From Cliente


Create Table Fornecedor
(Cod_Fornecedor int not null primary key identity (1,1),
Nome_Fornecedor varchar (70) not null,
Nif_Fornecedor Decimal (18) not null,
Quantidade_Fornecida int not null,
Data_Fornecida Date not null)

      insert into Fornecedor Values ('papito','104390','12','2022-05-11')
      insert into Fornecedor Values ('Anderson','230948','23','2022-07-22')
      insert into Fornecedor Values ('Leobone','209837','50','2022-11-21')
      insert into Fornecedor Values ('Adilson','376459','62','2022-09-30')

  Select*
  From Fornecedor


Create table Funcionario
(Cod_Funcionario int not null primary key identity (1,1),
Nome_Funcionario varchar (50) not null,
Sexo varchar (1) not null,
Cargo varchar (50) not null,
Endereço varchar(50) not null,
Telefone int not null)
	
	 insert into Funcionario Values ('Ricardinho','M','Gerente','Nova-Vida','992500069')
     insert into Funcionario Values ('Neide','F','Assistente de caixa','Talatona','939078779')
     insert into Funcionario Values ('Maria','F','Assistente de caixa','Viana','942845685')
     insert into Funcionario Values ('Nadioreth','F','Contabilista','Viana','990765678')
	 insert into Funcionario Values ('Márcio','M','Tecnico de Informática','Vila-alice','998456785')
	 insert into Funcionario Values ('Fernandes','M','Assistente de caixa','Kilamba','945567884')

  Select*
  From Funcionario
       
	 
Create table Venda
(Cod_Venda int not null primary key identity (1,1),
Cod_Produto int not null foreign key references Produto(Cod_Produto),
Quantidade int not null,
Cod_cliente int not null foreign key references Cliente(Cod_Cliente),
Cod_Funcionario int not null foreign key references Funcionario(Cod_Funcionario),
Data_Venda date not null)

     insert into Venda Values ('1','2','10','3','2022-11-20')
     insert into Venda Values ('3','4','7','4','2022-11-21')
     insert into Venda Values ('2','2','5','2','2022-11-23')
     insert into Venda Values ('3','7','6','1','2022-11-25')
	 insert into Venda Values ('5','4','8','6','2022-12-1')
	 insert into Venda Values ('6','2','9','2','2022-12-5')
	 insert into Venda Values ('7','1','1','1','2022-12-6')
   
  Select*
  From Venda

---------------------------------------Consultar as tabelas------------------------------------------
Select* 
From Produto

Select* 
From Cliente

Select*
From Fornecedor

Select*
From Funcionario

Select*
From Venda
--------------------------------------------Comandos---------------------------------------------------


-----------------Update-----------------
Update Fornecedor set Nome_Fornecedor = 'Habacuque',Nif_Fornecedor = '267837'where Cod_Fornecedor = '1'
Update Cliente set Nome_Cliente = 'Denilson',Morada = 'Kilamba', Contacto = '990567655'where Cod_Cliente = '5'
-----------------Between----------------
   select Nome_Produto, Quantidade
   From Produto
   Where Quantidade between '10' and '14'

   select Nome_Funcionario, Cargo
   From Funcionario
   Where Cargo between 'Assistente de caixa' and 'Contabilista'

--~-------------Order by-----------------
   Select Nome_Produto, Preço
   From Produto
   order by Preço asc
   
   Select Nome_Produto, Preço
   From Produto
   Order by Preço desc

---------------Group by------------------
   Select Nome_Produto
   From Produto
   Group by Nome_Produto

----------------Where--------------------
   Select Nome_Cliente, Sexo, Idade
   From Cliente
   Where Idade>=18 and Sexo='F' Order by Idade asc

   Select Nome_Funcionario, Sexo, Cargo
   From Funcionario
   Where Sexo='F' and Cargo='Assistente de caixa' Order by Nome_Funcionario asc

-----------------AS----------------------
   Select Nome_Produto As Produto
   From Produto

   Select Nome_Fornecedor As Fornecedor, Nif_Fornecedor As NIF
   From Fornecedor

   Select Nome_Produto As Produto, Quantidade As STOCK
   From Produto

-------------Alter table-----------------
alter table Cliente add Idade int not null
 alter table Cliente add Bilhete varchar (90) not null
  alter table Cliente drop column Morada
   alter table Cliente add Morada int not null
    alter table Cliente alter column Morada numeric (11)


  Select Max (Preço)
  from Produto
		
    Select Min (Preço)
	from Produto

	  Select SUM (Preço)
	  from Produto

		Select count (Preço)
		from Produto

		  Select avg (Preço)
		  from Produto

--------------Inner join--------------
 Select Nome_Produto, Nome_Fornecedor 
 From Fornecedor Inner join Produto on
 Fornecedor.Cod_Fornecedor=Produto.Cod_Produto

---------------Truncate---------------
Truncate table Venda



	 select Cod_Produto, Data_Venda
	 from Venda
	 Where Data_Venda='2022-12-6' 






