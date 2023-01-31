Create Database Loja
use Loja

-------------------------------Criação das tabelas---------------------------------~--

Create table Produto
(Cod_Produto int not null primary key identity (1,1),
Nome_Produto varchar (50) not null,
Preço decimal (18) not null,
Quantidade int not null,
Data_registo date not null,
Cod_Fornecedor int not null foreign key references Fornecedor(Cod_Fornecedor)
)

   Select* 
   From Produto

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


Create Table Cliente 
(Cod_Cliente int not null primary key identity (1,1),
Nome_Cliente varchar (70) not null,
Morada varchar (70) not null,
Sexo varchar (1) not null,
Contacto int not null,
Cod_Produto int not null foreign key references Produto(Cod_Produto)
)

   Select* 
   From Cliente
     
	  insert into Cliente Values ('Jessé','Talatona','M','992500069','2')
      insert into Cliente Values ('Leo','Mutamba','M','912500069','3')
      insert into Cliente Values ('Bombito','Zango','M','912500069','5')
      insert into Cliente Values ('Ricardo','Nova-Vida','M','939078779','7')
      insert into Cliente Values ('Jessé','Talatona','M','992500069','2')
      insert into Cliente Values ('Adelaide','Camama','F','997078777','8')
      insert into Cliente Values ('Rissara','Viana','F','942855684','8')
      insert into Cliente Values ('Daniel','Nova-Vida','M','939098776','3')
      insert into Cliente Values ('Janeth','Golf','F','945477677','1')
      insert into Cliente Values ('Ivanilson','Filda','M','998776544','10')

Create Table Fornecedor
(Cod_Fornecedor int not null primary key identity (1,1),
Nome_Fornecedor varchar (70) not null,
Nif_Fornecedor Decimal (18) not null,
Quantidade int not null,
Data_Fornecedor Date not null,
)

   Select*
   From Fornecedor

      insert into Fornecedor Values ('papito','0044567990','12','2022-05-11')
      insert into Fornecedor Values ('Anderson','00445578990','23','2022-07-22')
      insert into Fornecedor Values ('Leobone','084568990','50','2022-11-21')
      insert into Fornecedor Values ('Adilson','00678567990','62','2022-09-30')


Create table Funcionario
(Cod_Funcionario int not null primary key identity (1,1),
Nome_Funcionario varchar (50) not null,
Sexo varchar (1) not null,
Cargo varchar (50) not null,
Endereço varchar(50) not null,
Telefone int not null,
)

   Select*
   From Funcionario
       
	 insert into Funcionario Values ('Jessé','M','Gerente','Nova-Vida','992500069')
     insert into Funcionario Values ('Neide','F','Assistente de caixa','Talatona','939078779')
     insert into Funcionario Values ('Maria','F','Assistente de caixa','Viana','942845685')
     insert into Funcionario Values ('Nadioreth','F','Contabilista','Viana','990765678')
	 insert into Funcionario Values ('Márcio','M','Tecnico de Informática','Vila-alice','998456785')
	 

Create table Factura
(Cod_Factura int not null primary key identity (1,1),
Cod_cliente int not null foreign key references Cliente(Cod_Cliente),
Data_Factura date not null,
)

   Select*
   From Factura

     insert into Factura Values ('Jessé','M','Gerente','Nova-Vida','992500069')
     insert into Factura Values ('Neide','F','Assistente de caixa','Talatona','939078779')
     insert into Factura Values ('Maria','F','Assistente de caixa','Viana','942845685')
     insert into Factura Values ('Nadioreth','F','Contabilista','Viana','990765678')
	 insert into Factura Values ('Márcio','M','Tecnico de Informática','Vila-alice','998456785')
	 insert into Factura Values ('Jessé','M','Gerente','Nova-Vida','992500069')
	 insert into Factura Values ('Jessé','M','Gerente','Nova-Vida','992500069')
   


Create table Venda
(Cod_Factura int not null foreign key references Factura(Cod_Factura),
Cod_Produto int not null foreign key references Produto(Cod_Produto),
Preço decimal (18) not null,
Quantidade int not null,
Cod_Funcionario int not null foreign key references Funcionario(Cod_Funcionario)
)
   
   Select*
   From Venda

---------------------------------------Consultas----------------------------------------------

Select Nome_Fornecedor
From Fornecedor

Select Nome_Fornecedor, Nif_Fornecedor, Quantidade
From Fornecedor



-------------------------------------Comandos-----------------------------------------------------

delete from Produto where Cod_Produto = '2'
Update Produto set Nome_Produto = 'Dico Duro',Preço = '15000'where Cod_Produto = '4'
Update Produto set Nome_Produto = 'Dico Duro',Quantidade = '5'where Cod_Produto = '4'
Update Produto set Nome_Produto = 'Computadores',Preço = '200000'where Cod_Produto = '5'
Update Fornecedor set Nome_Fornecedor = 'Sociedade Garcia e Filhos',Nif_Fornecedor = '4896061922',Data_Fornecedor = '2022-10-09'where Cod_Fornecedor = '2'

   select Nome_Produto, Quantidade
   From Produto
   Where Quantidade between '10' and '14'

     Select Nome_Produto, Preço
     From Produto
     order by Preço asc
     
	 Select Nome_Produto, Preço
     From Produto
     Order by Preço desc

        Select Nome_Produto
        From Produto
        Group by Nome_Produto

          Select Nome_Cliente, Sexo, Idade
          From Cliente
          Where Idade>=18 and Sexo='M' Order by Idade asc

            Select Nome_Produto As Produto
            From Produto

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

 Select Nome_Produto, Nome_Fornecedor 
 From Fornecedor Inner join Produto on
 Fornecedor.Cod_Fornecedor=Produto.Cod_Produto

   Truncate table Cliente
     
	 







