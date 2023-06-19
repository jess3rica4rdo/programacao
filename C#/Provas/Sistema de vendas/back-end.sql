Create Database loja
Use loja

---------------------CRIAÇÃO DAS TABELAS-------------------------

Create Table usuario                                              
(cod_usuario int not null primary key identity (1,1), 
nome_completo varchar (80) not null,
idade varchar (2) not null,
genero varchar (10) not null, 
telefone Varchar (20) not null,  
nome_usuario varchar (10) not null, 
senha Varchar (10) not null, 
funcao Varchar (20) not null, 
add_por varchar (20) not null,
data_registro datetime default getdate())


Create Table produto
(cod_produto int not null primary key identity (1,1), 
nome_produto varchar (80) not null,
categoria varchar (80) not null,
descricao varchar (80) not null,
estado varchar (80) not null,
stock int default 0,
preco_compra decimal (10,2) default 0,
preco_venda decimal (10,2) default 0,
add_por varchar (80) not null,
data_registro datetime default getdate())


Create Table cliente
(cod_cliente int not null primary key identity (1,1), 
nome_completo varchar (50) not null,
email varchar (50) not null,
telefone varchar (50) not null,
add_por varchar (50) not null,
data_registro datetime default getdate())


Create Table fornecedor
(cod_fornecedor int not null primary key identity (1,1), 
nif varchar (50) not null,
razao_social varchar (50) not null,
email varchar (50) not null,
telefone varchar (50) not null,
add_por varchar (50) not null,
data_registro datetime default getdate())


Create Table compra
(cod_compra int not null primary key identity (1000,1), 
cod_produto int not null foreign key references produto(cod_produto),
cod_fornecedor int not null foreign key references fornecedor(cod_fornecedor),
preco_compra varchar(50) default 0,
quantidade varchar(50) default 0,
subtotal varchar(50) default 0, 
valor_total varchar(50) default 0, 
data_compra varchar(50) not null,
tipo_documento varchar(50), 
registrado_por varchar(50))


create Table venda
(cod_venda int not null primary key identity (1,1), 
cod_produto int not null foreign key references produto(cod_produto),
cod_cliente int not null foreign key references cliente(cod_cliente),
preco_venda varchar (50) default 0, 
quantidade varchar (50) default 0,
subtotal varchar (50) default 0,
iva varchar (50) default 0,
valor_total varchar (50) default 0, 
valor_pago varchar (50) default 0,
troco varchar (50) default 0,
data_venda varchar (50) default 0,
forma_pagamento varchar (50) default 0,
cod_usuario int not null foreign key references usuario(cod_usuario))


------------------------------------CONSULTAS--------------------------------------------    

SELECT*
FROM usuario        

SELECT*
FROM produto

SELECT*
FROM cliente

SELECT* 
FROM fornecedor

SELECT*
FROM compra

SELECT*
FROM venda

----------------------------consultas para relatório-------------------------------------

------------------------------------compra-----------------------------------------------

select

Convert(char(10),c.data_compra,103)[Data da compra],c.tipo_documento[Documento],
p.nome_produto[Produto],
c.preco_compra[Preço de compra],c.quantidade[Quantidade],c.valor_total[Total],
pr.nif[NIF Fornecedor],
u.nome_completo[Registrado por]

from compra c

inner join usuario u on u.nome_completo = c.registrado_por
inner join fornecedor pr on pr.cod_fornecedor = c.cod_fornecedor
inner join produto p on p.cod_produto = c.cod_produto

-------------------------------------Venda---------------------------------------------

select

Convert(char(10),v.data_venda,103)[Data de venda],
p.nome_produto[Produto],
v.preco_venda[Preço de venda],v.quantidade[Quantidade],v.subtotal[Subtotal],
v.iva[Imposto],v.valor_total[Valor Total],v.valor_pago[Valor Pago],
v.troco[Troco],v.forma_pagamento[Forma de Pagamento],
j.nome_completo[Cliente],
u.nome_completo[Efetuada por]

from venda v

inner join usuario u on u.cod_usuario = v.cod_usuario
inner join cliente j on j.cod_cliente = v.cod_cliente
inner join produto p on p.cod_produto = v.cod_produto


----------------------------INSERÇÃO DE VALORES DEPENDENTES-------------------------------

INSERT INTO usuario(nome_completo,idade,genero,telefone,nome_usuario,senha,funcao,add_por) VALUES ('Jessé Neto','18','Masculino','+244 992500069','jn18','123','ADMINISTRADOR',1)

---------------------------------Fim de código--------------------------------------------


truncate table compra