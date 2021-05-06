INSERT [dbo].[AspNetRoles] (id,Name) VALUES  (1,'Administrador') 
 
INSERT [dbo].[AspNetRoles] (id,Name) VALUES  (2,'Alumno') 

INSERT [dbo].[AspNetRoles] (id,Name) VALUES  (3,'Profesor') 

declare @id nvarchar(128)
	select @id=id from AspNetUsers where UserName='manumouso91@gmail.com'
 

INSERT INTO AspNetUserRoles
(UserId,RoleId)VALUES (@id ,1)



select *from AspNetUserRoles
select * from AspNetUsers
select * from AspNetRoles

use SeguridadApp;
go
create procedure [dbo].[AltaRoles]
(
/* argumentos */
	@Id nvarchar (128),
	@UserName varchar(50),
	@RoleId nvarchar(128)
)
as
 select @Id=id from AspNetUsers where UserName=@UserName
	insert into AspNetUserRoles(UserId,RoleId)
	values (@Id,@RoleId)
go	

USE SeguridadApp
go
create view ListaUsuarioRoles
as
select u.UserName as'Nombre Usuario', m.Name as 'Rol'
from AspNetUserRoles as r JOIN AspNetUsers as u
ON r.UserId = u.Id
join AspNetRoles as m
on r.RoleId=m.Id;

go
select *
from SeguridadApp.dbo.ListaUsuarioRoles
order by [Nombre Usuario];

update AspNetRoles set Name='Administrador'
where id=1;

update AspNetRoles set Name='Alumno'
where id=2;

update AspNetRoles set Name='Profesor'
where id=3;


use SeguridadApp
go
alter table [dbo].[AspNetUserRoles] add Funcion varchar(50) NULL;