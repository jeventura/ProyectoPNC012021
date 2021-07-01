CREATE DATABASE BibliotecaNCAPAS02



CREATE TABLE Empleado
(
Dui VARCHAR(10) PRIMARY KEY NOT NULL,
Nombre VARCHAR(50) NOT NULL,
Rol VARCHAR(30) NOT NULL,
Materia VARCHAR(20),
Nivel VARCHAR(20),
Usuario VARCHAR(10) NOT NULL,
Contrasenna VARCHAR(20) NOT NULL
);

go

CREATE TABLE Libro
(
Codigo_Libro INT PRIMARY KEY  IDENTITY (1,1) NOT NULL,
Numero_Ejemplares INT,
ISBN VARCHAR(17),
Titulo VARCHAR(50),
Autor VARCHAR(20),
Editorial VARCHAR(30),
Anno_Edicion INT,
Numero_Edicion INT,
Pais VARCHAR(50),
Idioma VARCHAR(20),
Materia VARCHAR(20),
Numero_Paginas INT,
Ubicacion VARCHAR(100),
Descripcion VARCHAR(250),
Estado Bit 
);

go

CREATE TABLE Video
(
Codigo_Video INT PRIMARY KEY  IDENTITY (1,1) NOT NULL,
Titulo VARCHAR(50),
Director VARCHAR(20),
Productora VARCHAR(30),
Tipo VARCHAR(17),
Anno INT,
Duracion Varchar(10),
Pais VARCHAR(50),
Idioma VARCHAR(20),
Subtitulos VARCHAR(20),
Clasificacion Varchar(3),
Genero VARCHAR(50),
Sinopsis VARCHAR(50),
Ubicacion VARCHAR(100),
Estado Bit 
);

go

CREATE TABLE Prestamo
(
Id_Prestamo INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
Fecha_Prestamo DATE NOT NULL,
Fecha_Devolucion DATE NOT NULL,
DUI_Encargado VARCHAR(10),
DUI_Profesor VARCHAR(10),
Codigo_Libro INT,
Codigo_Video INT
);

go

ALTER TABLE Prestamo 
ADD FOREIGN KEY (DUI_Encargado) REFERENCES Empleado(Dui);

go

ALTER TABLE Prestamo 
ADD FOREIGN KEY (DUI_Profesor) REFERENCES Empleado(Dui);

go

ALTER TABLE Prestamo 
ADD FOREIGN KEY (Codigo_Libro) REFERENCES Libro(Codigo_Libro);

go

ALTER TABLE Prestamo 
ADD FOREIGN KEY (Codigo_Video) REFERENCES Video(Codigo_Video);

go

CREATE TABLE Devolucion
(
Id_Devolucion INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
Fecha_Devolucion DATE,
DUI_Encargado VARCHAR(10),
DUI_Profesor VARCHAR(10),
Id_Prestamo INT
);

go

ALTER TABLE Devolucion
ADD FOREIGN KEY (DUI_Encargado) REFERENCES Empleado(Dui);
go
ALTER TABLE Devolucion
ADD FOREIGN KEY (DUI_Profesor) REFERENCES Empleado(Dui);
go
ALTER TABLE Devolucion
ADD FOREIGN KEY (Id_Prestamo) REFERENCES Prestamo(Id_Prestamo);

go

--Inserts de empleados
INSERT INTO Empleado (Dui,Nombre,Rol,Materia,Nivel,Usuario,Contrasenna)
VALUES 
('02554806-5','Raul Castro','Profesor','Estudios Sociales','Superior','Cuba86','Cuba libre');

go

INSERT INTO Empleado (Dui,Nombre,Rol,Materia,Nivel,Usuario,Contrasenna)
VALUES 
('11259906-3','Adolf Hittler','Profesor','Arte','Superior','AH2021','contrasena1234');

go

INSERT INTO Empleado (Dui,Nombre,Rol,Materia,Nivel,Usuario,Contrasenna)
VALUES 
('89763606-2','Armando Paredes','Profesor','Dibujo Tecnico','Basico','AP0021','9876abc');

go

INSERT INTO Empleado (Dui,Nombre,Rol,Materia,Nivel,Usuario,Contrasenna)
VALUES 
('88962021-8','Camilo Sesto','Administrador',NULL,NULL,'CASES25','3654bcde');

go

INSERT INTO Empleado (Dui,Nombre,Rol,Materia,Nivel,Usuario,Contrasenna)
VALUES 
('58962021-9','Ricardo Arjona','Administrador',NULL,NULL,'RA95','AJ45');

go

--Insert de libros (4 ejemplares)
INSERT INTO Libro (Numero_Ejemplares,ISBN,Titulo,Autor,
Editorial,Anno_Edicion,Numero_Edicion,Pais,Idioma,Materia,Numero_Paginas,
Ubicacion,Descripcion,Estado)
VALUES 
(1,'0735615780','Building Web Solutions with ASP.NET and ADO.NET','Dino Esposito',
'Microsoft Press',2002,1,'Estados Unidos','Ingles','programacion',416,'piso 2 estante 45',
'programacion con ADO.NET',0);

go

INSERT INTO Libro (Numero_Ejemplares,ISBN,Titulo,Autor,
Editorial,Anno_Edicion,Numero_Edicion,Pais,Idioma,Materia,Numero_Paginas,
Ubicacion,Descripcion,Estado)
VALUES 
(1,'8448131932','Java 2 - Manual de Programacion','Luis Joyanes',
'McGraw Hill',2001,1,'Mexico','español','programacion',568,
'piso 2 estante 46','programacion en lenguaje java',1);

go

INSERT INTO Libro (Numero_Ejemplares,ISBN,Titulo,Autor,
Editorial,Anno_Edicion,Numero_Edicion,Pais,Idioma,Materia,Numero_Paginas,
Ubicacion,Descripcion,Estado)
VALUES 
(1,'1587200945','CCNA intro exam certification guide','Wendell Odom',
'Cisco Press',2003,2,'Estados Unidos','ingles','redes de computadora',648,
'piso 3 estante 30','configuracion de redes de computadoras',0);

go

INSERT INTO Libro (Numero_Ejemplares,ISBN,Titulo,Autor,
Editorial,Anno_Edicion,Numero_Edicion,Pais,Idioma,Materia,Numero_Paginas,
Ubicacion,Descripcion,Estado)
VALUES 
(1,'8428328145','Fisica 1 la naturaleza de las cosas','Susan Lea',
'thompson editores', 2001, 1,'Mexico','español','fisica',504,
'piso 1 estante 10','ciencias naturales',1);

go

--inserts de Videos

INSERT INTO Video(Titulo,Director,Productora,
Tipo,Anno,Duracion,Pais, Idioma,Subtitulos,Clasificacion,
Genero,Sinopsis,Ubicacion,Estado)
VALUES 
('Numeros Complejos y donde encontrarlos', 'Alfedo Galan', 'c&h',
'Documental',2018,'01:30:22','Espanna','Espanol','Ingles','D',
'Suspenso','Explicacion detallada de los numeros Complejos','Sala de Videoteca, Estante 4',1)

go

--inserts de Prestamos
INSERT INTO Prestamo (Fecha_Prestamo,Fecha_Devolucion,DUI_Encargado,
DUI_Profesor,Codigo_Libro)
VALUES 
(CONVERT(DATE,'2020-11-30'),CONVERT(DATE,'2020-11-30'),'58962021-9','11259906-3',1);

go

INSERT INTO Prestamo (Fecha_Prestamo,Fecha_Devolucion,DUI_Encargado,
DUI_Profesor,Codigo_Libro)
VALUES 
(CONVERT(DATE,'2020-11-30'),CONVERT(DATE,'2020-11-30'),'88962021-8','02554806-5',2);

go

--insert de devolucion
INSERT INTO Devolucion(Fecha_Devolucion,
DUI_Encargado,DUI_Profesor,Id_Prestamo)
VALUES 
(CONVERT(DATE,'2020-11-30'),'88962021-8','11259906-3',1);

--Procedimiento Listar
create proc libros_listar 
as
select Codigo_Libro as Codigo, titulo as Titulo, autor as Autor, editorial as Editorial, Materia as Materia,  Anno_Edicion as año, Estado as Estado
from Libro
order by Codigo_Libro asc
go

--Procedimiento Buscar

create proc libros_buscar
@valor varchar(50)
as
select Codigo_Libro as Codigo, titulo as Titulo, autor as Autor, editorial as Editorial, Anno_Edicion as año
from Libro
where Titulo like '%' + @valor +'%' or Autor like '%' +@valor + '%' or Editorial like '%' + @valor + '%' or Materia like '%' + @valor + '%'
order by Titulo  asc
go

--Procedimiento Insertar
create proc libros_insertar
@Numero_Ejemplares int, 
@ISBN varchar(17),
@Titulo varchar(50),
@Autor varchar(20),
@Editorial varchar(30),
@Anno_Edicion int,
@Numero_Edicion int,
@Pais varchar(50),
@Idioma varchar(20),
@Materia varchar(20),
@Numero_Paginas int,
@Ubicacion varchar(100),
@Descripcion varchar(250),
@Estado bit
as 
insert into Libro (Numero_Ejemplares, ISBN, Titulo, Autor, Editorial, Anno_Edicion,Numero_Edicion, Pais, Idioma, Materia, Numero_Paginas, Ubicacion, Descripcion, Estado)
values (@Numero_Ejemplares, @ISBN, @Titulo, @Autor, @Editorial, @Anno_Edicion, @Numero_Edicion, @Pais, @Idioma, @Materia, @Numero_Paginas, @Ubicacion, @Descripcion, @Estado)
go


--Procedimiento Actualizar
create proc libros_actualizar
@Codigo_Libro int,
@Numero_Ejemplares int, 
@ISBN varchar(17),
@Titulo varchar(50),
@Autor varchar(20),
@Editorial varchar(30),
@Anno_Edicion int,
@Numero_Edicion int,
@Pais varchar(50),
@Idioma varchar(20),
@Materia varchar(20),
@Numero_Paginas int,
@Ubicacion varchar(100),
@Descripcion varchar(250),
@Estado bit
as
update Libro set Numero_Ejemplares=@Numero_Ejemplares, ISBN=@ISBN, Titulo=@Titulo, Autor=@Autor, Editorial=@Editorial, Anno_Edicion=@Anno_Edicion, 
                 Numero_Edicion=@Numero_Edicion, Pais=@Pais, Idioma=@Idioma, Materia=@Materia, Numero_Paginas=@Numero_Paginas, Ubicacion=@Ubicacion,
				 Descripcion=@Descripcion, Estado=@Estado
where Codigo_Libro=@Codigo_Libro
go


--Procedimiento Eliminar
create proc libros_eliminar
@Codigo_libro int
as
delete from Libro
where Codigo_Libro=@Codigo_libro
go
--Procedimiento prestar
create proc libros_prestar
@Codigo_libro int
as
update Libro set Estado=0
where Codigo_Libro=@Codigo_libro
go

--Procedimiento devolver
create proc	libros_devolver
@Codigo_libro int
as
update Libro set Estado=1
where Codigo_Libro=@Codigo_libro

go

create proc libros_existe
@valor varchar(100), 
@existe bit output
as
	if exists (select Titulo from Libro where Titulo =ltrim(rtrim(@valor)))
		begin
		 set @existe=1
		end
	else
		begin
		 set @existe=0
		end