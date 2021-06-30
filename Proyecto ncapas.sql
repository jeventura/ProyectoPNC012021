CREATE DATABASE BibliotecaNCAPAS


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
Codigo_Libro VARCHAR(10) PRIMARY KEY NOT NULL,
Numero_Ejemplares int,
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
Estado VARCHAR(20) 
);

go

CREATE TABLE Prestamo
(
Id_Prestamo INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
Fecha_Prestamo DATE NOT NULL,
Fecha_Devolucion DATE NOT NULL,
DUI_Encargado VARCHAR(10),
DUI_Profesor VARCHAR(10),
Codigo_Libro VARCHAR(10)
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
INSERT INTO Libro (Codigo_Libro,Numero_Ejemplares,ISBN,Titulo,Autor,
Editorial,Anno_Edicion,Numero_Edicion,Pais,Idioma,Materia,Numero_Paginas,
Ubicacion,Descripcion,Estado)
VALUES 
('A001',1,'0735615780','Building Web Solutions with ASP.NET and ADO.NET','Dino Esposito',
'Microsoft Press',2002,1,'Estados Unidos','Ingles','programacion',416,'piso 2 estante 45',
'programacion con ADO.NET','prestado');

go

INSERT INTO Libro (Codigo_Libro,Numero_Ejemplares,ISBN,Titulo,Autor,
Editorial,Anno_Edicion,Numero_Edicion,Pais,Idioma,Materia,Numero_Paginas,
Ubicacion,Descripcion,Estado)
VALUES 
('A002',1,'8448131932','Java 2 - Manual de Programacion','Luis Joyanes',
'McGraw Hill',2001,1,'Mexico','español','programacion',568,
'piso 2 estante 46','programacion en lenguaje java','disponible');

go

INSERT INTO Libro (Codigo_Libro,Numero_Ejemplares,ISBN,Titulo,Autor,
Editorial,Anno_Edicion,Numero_Edicion,Pais,Idioma,Materia,Numero_Paginas,
Ubicacion,Descripcion,Estado)
VALUES 
('A003',1,'1587200945','CCNA intro exam certification guide','Wendell Odom',
'Cisco Press',2003,2,'Estados Unidos','ingles','redes de computadora',648,
'piso 3 estante 30','configuracion de redes de computadoras','prestado');

go

INSERT INTO Libro (Codigo_Libro,Numero_Ejemplares,ISBN,Titulo,Autor,
Editorial,Anno_Edicion,Numero_Edicion,Pais,Idioma,Materia,Numero_Paginas,
Ubicacion,Descripcion,Estado)
VALUES 
('A004',1,'8428328145','Fisica 1 la naturaleza de las cosas','Susan Lea',
'thompson editores', 2001, 1,'Mexico','español','fisica',504,
'piso 1 estante 10','ciencias naturales','disponible');

go

--inserts de Prestamos
INSERT INTO Prestamo (Fecha_Prestamo,Fecha_Devolucion,DUI_Encargado,
DUI_Profesor,Codigo_Libro)
VALUES 
(CONVERT(DATE,'2020-11-30'),CONVERT(DATE,'2020-11-30'),'58962021-9','11259906-3','A001');

go

INSERT INTO Prestamo (Fecha_Prestamo,Fecha_Devolucion,DUI_Encargado,
DUI_Profesor,Codigo_Libro)
VALUES 
(CONVERT(DATE,'2020-11-30'),CONVERT(DATE,'2020-11-30'),'88962021-8','02554806-5','A004');

go

--insert de devolucion
INSERT INTO Devolucion(Fecha_Devolucion,
DUI_Encargado,DUI_Profesor,Id_Prestamo)
VALUES 
(CONVERT(DATE,'2020-11-30'),'88962021-8','11259906-3',1);

