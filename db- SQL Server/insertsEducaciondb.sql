go
INSERT [dbo].[Alumnos] ([Dni], [Apellido], [Nombre], [Email]) VALUES ( '90525425','Garcia','Pedro' ,'pedrito@gmail.com')
GO
go
INSERT [dbo].[Alumnos] ( [Dni], [Apellido], [Nombre], [Email]) VALUES ( '80525425','Garcia','Manuel' ,'manuelgarcia@gmail.com')
GO
go
INSERT [dbo].[Alumnos] ( [Dni], [Apellido], [Nombre], [Email]) VALUES ( '70525427','Marcia','Pedro' ,'marcia.p@gmail.com')
GO
go
INSERT [dbo].[Alumnos] ( [Dni], [Apellido], [Nombre], [Email]) VALUES ( '905254','Parcia','Rober' ,'rober@gmail.com')
GO
go
INSERT [dbo].[Alumnos] ( [Dni], [Apellido], [Nombre], [Email]) VALUES ( '9055425','Borges','Jorge Manuel' ,'jm.borges@gmail.com')
GO
go
INSERT [dbo].[Alumnos] ( [Dni], [Apellido], [Nombre], [Email]) VALUES ( '8074425','Cortazar','Julio' ,'cortazar@gmail.com')
GO
go
INSERT [dbo].[Alumnos] ( [Dni], [Apellido], [Nombre], [Email]) VALUES ( '70125425','Garcia Marquez','Gabriel' ,'marquez12@gmail.com')
GO
go
INSERT [dbo].[Alumnos] ( [Dni], [Apellido], [Nombre], [Email]) VALUES ( '7784125','Bioy Casares','Adolfo' ,'el_adolfo@gmail.com')
GO
go
INSERT [dbo].[Alumnos] ( [Dni], [Apellido], [Nombre], [Email]) VALUES ( '7012545','Galeano','Eduardo' ,'galen@gmail.com')
GO
go
INSERT [dbo].[Alumnos] ( [Dni], [Apellido], [Nombre], [Email]) VALUES ( '78741425','Mistral','Gabriela' ,'gabimistral@gmail.com')
GO

select * from Alumnos

--CAST(N'1971-12-20' AS Date)
select * from Cursos

go
INSERT [dbo].[Cursos] ([Codigo], [Descripcion], [Inicio], [Fin],[Estado],[CantidadClases]) VALUES ( 'TSSI-2020','Tecnicatura Superior en Sistemas Informaticos','2020-3-16','2020-11-23','ABIERTO',225)
GO
go
INSERT [dbo].[Cursos] ([Codigo], [Descripcion], [Inicio], [Fin],[Estado],[CantidadClases]) VALUES ( 'THST-2020','Tecnicatura en Higiene y Seguridad del Trabajo','2020-3-16','2020-11-28','CERRADO',174)
GO
go
INSERT [dbo].[Cursos] ([Codigo], [Descripcion], [Inicio], [Fin],[Estado],[CantidadClases]) VALUES ( 'FPG-2020','Formacion Profesional de Guardavidas','2020-3-16','2020-11-23','ABIERTO',173)
GO

go
INSERT [dbo].[Cursos] ([Codigo], [Descripcion], [Inicio], [Fin],[Estado],[CantidadClases]) VALUES ( 'TSCTV-2020','Tecnicatura Superior en Realizacion de Cine,TV y Video','2020-3-16','2020-11-23','ABIERTO',90)
GO

go
INSERT [dbo].[Cursos] ([Codigo], [Descripcion], [Inicio], [Fin],[Estado],[CantidadClases]) VALUES ( 'IPR-2020','Introduccion a la Programacion Robotica','2020-4-16','2020-11-12','CERRADO',30)
GO

go
INSERT [dbo].[Cursos] ([Codigo], [Descripcion], [Inicio], [Fin],[Estado],[CantidadClases]) VALUES ( 'TSES-2020','Tecnicatura Superior en Emergencias de la Salud','2020-03-15','2020-08-16','A CONFIRMAR',50)
GO
go
INSERT [dbo].[Cursos] ([Codigo], [Descripcion], [Inicio], [Fin],[Estado],[CantidadClases]) VALUES ( 'TSOFT-2020','Testing de Software','2020-03-17','2020-07-07','ABIERTO',15)
GO

go
INSERT [dbo].[Cursos] ([Codigo], [Descripcion], [Inicio], [Fin],[Estado],[CantidadClases]) VALUES ( 'DAPPM-2020','Desarrollo de Aplicaciones Moviles','2020-3-16','2020-07-20','ABIERTO',19)
GO

go
INSERT [dbo].[Cursos] ([Codigo], [Descripcion], [Inicio], [Fin],[Estado],[CantidadClases]) VALUES ( 'PWEB-2020','Programacion WEB','2020-4-16','2020-07-23','ABIERTO',18)
GO

go
INSERT [dbo].[Cursos] ([Codigo], [Descripcion], [Inicio], [Fin],[Estado],[CantidadClases]) VALUES ( 'PPHYTON-2020','Programacion Phyton','2020-3-12','2020-06-23','ABIERTO',12)
GO



go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'ING-01','Ingles I',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'PROG-01','Programacion I',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'SPD','Sistemas de procesamiento de datos',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'MAT-01','Matematica I',32)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'LAB-01','Laboratorio de computacion I',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'EST','Estadistica',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'ING-02','Ingles II',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'PROG-02','Programacion II',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'SO','Arquitectura y sistemas operativos',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'LAB-02','Laboratorio de computacion II',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'MI','Metodologia de la investigacion',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'PROG-03','Programacion III',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'OCE','Organizacion contable de la empresa',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'OE','Organizacion empresarial',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'EIO','Elementos de investigacion operativa',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'LAB-03','Laboratorio de computacion III',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'LEG','Legislacion',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'MS-01','Metodologia de sistemas I',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'DB','Diseño y administracion de base de datos',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'LAB-04','Laboratorio de computacion IV',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'PF','Practica Profesional',16)
GO


select * from Materias

go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'IPMC','I. problematica del mundo contemporaneo',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'QUI-01','Quimica I',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'ILPP','Introduccion legal a la practica profesional',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'ALG','Algebra',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'CSEP','Cuestiones de sociologia economia y politica',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'SEGO-01','Seguridad ocupacional I',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'RG','Representacion grafica',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'PHSXX','Problemas de historia del siglo XX',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'CULC','Cultura contemporanea',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'IDI-01','Idioma nivel I',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'INF-01','Informatica nivel I',16)
GO


go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'HSC','Historia social del cine',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'SEMI','Semiologia de la imagen',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'GUI-01','Guion I',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'TCIS-01','Taller de camara, iluminacion y sonido I',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'DIRV','Direccion de video(T.R I)',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'IDAC','Introduccion a la direrccion de actores',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'TME-01','Teoria del montaje y edicion I',16)
GO
go
INSERT [dbo].[Materias] ([Codigo], [Descripcion], [CantidadClases]) VALUES ( 'PROD-01','Produccion I',16)
GO

select * from Profesores
 
 go
INSERT [dbo].[Profesores] ([Apellido], [Nombre], [Email]) VALUES ('Leonardo','Gomez' ,'gomleo@gmail.com')
GO
 go
INSERT [dbo].[Profesores] ([Apellido], [Nombre], [Email]) VALUES ('Alejandro','Perez' ,'ale.perez@gmail.com')
GO
 go
INSERT [dbo].[Profesores] ([Apellido], [Nombre], [Email]) VALUES ('Judit','Mathematician' ,'math.teach@gmail.com')
GO
go
INSERT [dbo].[Profesores] ([Apellido], [Nombre], [Email]) VALUES ('Señor','Vistosi' ,'vistosispd@gmail.com')
GO
go
INSERT [dbo].[Profesores] ([Apellido], [Nombre], [Email]) VALUES ('Ines','Ruffo' ,'ruffoines@gmail.com')
GO

go
INSERT [dbo].[Profesores] ([Apellido], [Nombre], [Email]) VALUES ('Ana','Grotsso' ,'anamgrotsso@gmail.com')
GO
go
INSERT [dbo].[Profesores] ([Apellido], [Nombre], [Email]) VALUES ('Francisca','Rodriguez' ,'rofa@gmail.com')
GO
go
INSERT [dbo].[Profesores] ([Apellido], [Nombre], [Email]) VALUES ('Matias','Costa' ,'costanesa@gmail.com')
GO

go
INSERT [dbo].[Profesores] ([Apellido], [Nombre], [Email]) VALUES ('Alberto','Podesta' ,'pod.alber@gmail.com')
GO
go
INSERT [dbo].[Profesores] ([Apellido], [Nombre], [Email]) VALUES ('Graciela','Lestorto' ,'lestort14@gmail.com')
GO
go
INSERT [dbo].[Profesores] ([Apellido], [Nombre], [Email]) VALUES ('Agustina','Munetto' ,'munetos@gmail.com')
GO