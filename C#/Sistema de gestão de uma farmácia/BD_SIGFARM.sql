Create Database SIG_FARMA
Use SIG_FARMA

-------------Cria��o da tabela Usu�rios--------------------
Create table Usu�rios
(
Codusuario int not null primary key identity (1,1),
Nome varchar (50)not null,
Usuario varchar (50)not null,
Senha varchar (40)not null,
Funcao varchar (40)not null)

select*
from Usu�rios

insert into Usu�rios values ('Celma Engracia','Celma','123','Admin')
insert into Usu�rios values ('Pedro Pembele','pedro','222','Operador de Caixa')
insert into Usu�rios values ('Ana Gomes','Ana','1234','Operadora de Caixa')

-----Pesquisar usuario a partir da Base de Dados----------
select* from Usu�rios
-----Eliminar usuario a partir da Base de dados----------------
delete from Usu�rios where CodUsuario = '6'

-------------Cria��o da tabela F�rmacos--------------------
Create table Farmacos  
(Cod_farmaco int not null primary key identity (1,1),
Nome_farmaco varchar (100) not null, 
Categoria varchar (50) not null, 
Preco varchar (40) not null, 
Qtd_Estoque int not null, 
Stock_minimo varchar (50) not null, 
Fornecedor varchar (40) not null, 
Data_registo date not null,
Descri��o varchar (80) not null
) 
-----Pesquisar Produto na Base de Dados----------
select* from Farmacos
-----Eliminar Produtos a partir da Base de dados----------------
update Farmacos set Qtd_Estoque = '500' where Cod_farmaco = '1' 

delete from Farmacos  where Cod_farmaco = '9'
insert into Farmacos values ('Soro fisiologico','Soro','250','75','50','Cecoma','2023-02-10', 'Diversos')
insert into Farmacos values ('Vitamina','Vitamina','250','75','50','Cecoma','2022-12-10','Diversos')

-------------Cria��o da tabela Factura--------------------
Create table Factura  
(Cod_factura int not null primary key identity (500,1),
Data_registo date not null
) 
-----Pesquisar Produto na Base de Dados----------
select* from Factura
-----Eliminar Produtos a partir da Base de dados----------------
delete from Factura  where Cod_factura = '5'
insert into Factura values ('2022-12-10')
insert into Factura values ('2022-02-10')
-------------Cria��o da tabela fornecedor--------------------
Create table Forncedores   
(Cod_fornecedor int not null primary key identity (1,1),
Nome varchar (100) not null, 
Telefone int not null, 
NIF varchar (20) not null, 
Email varchar (20)not null, 
Endereco varchar (20) not null,  
Data_Fornecedor date not null
) 
Select* 
From Forncedores
insert into Forncedores values ('Mozel','925076328','00045879042','mozel@gmail.com','Maianga, Rua 14','2023-01-12')











insert into Farmacos values ('amoxicilina','anti-infeccioso','2000','60','40','shalina','2023-12-01','Diversos')
insert into Farmacos values ('Vitamina','Vitamina','250','75','50','Cecoma','2022-12-10','Diversos')
insert into Farmacos values ('Metronidazol','anti-infeccioso','500','40','40','Shalina','2023-02-23','Diversos')
insert into Farmacos values ('Amidol-c','anti-inflam�torio','900','30','40','Mozel','2023-02-10','Diversos')
insert into Farmacos values ('Maladox','Anti-Mal�rico','5000','80','40','Mozel','2023-10-10','Diversos')
insert into Farmacos values ('Hemoforce','Nutri��o','3000','30','20','�nica','2023-01-30','Diversos')
insert into Farmacos values ('Vitamina B12','Nutri��o','1000','15','20','�nica','2023-12-10','Diversos')
insert into Farmacos values ('Vitamina B12','Nutri��o','1000','15','20','�nica','2023-01-28','Diversos')
insert into Farmacos values ('Artimeter','Anti-Mal�rico','5000','50','20','Farm�cia Central Kilamba','2022-12-10','Diversos')