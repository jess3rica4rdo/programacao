Create Database Aula
Use Aula

Create Table Cadastros 
(CodUsuario int not null primary key identity (1,1), 
Nome_completo varchar (80) not null, 
Usuario varchar (50) not null, 
Senha Varchar (10) not null, 
Fun��o Varchar (20)
)

select*
from Cadastros
insert into Cadastros values ('Castanheira','M�rio','1234','adm')
delete from Cadastros where CodUsuario = '6'


