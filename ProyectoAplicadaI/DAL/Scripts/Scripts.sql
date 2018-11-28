create database ProyectoDB
GO
USE ProyectoDB
GO
create TABLE Clientes
(	
	ClienteId int primary key identity(1,1),
	Nombre varchar(45),
    Cedula varchar(13),
	Telefono varchar(12),
    Direccion varchar(max)
);
go
create TABLE Articulos
(			
	   ArticuloId int primary key identity(1,1),
	   Nombre varchar(40),
	   Inventario int
);
go
create TABLE Empe�os
(			
	Empe�oId int primary key identity(1,1),
	ClienteId int,
	NombredeCliente varchar(45),
    Fecha  Date,
    MontoTotal money,
	Abono money,
	UltimaFechadeVigencia date
);
go
create TABLE Empe�osDetalle
(			
	ID int primary key identity(1,1),
    Empe�oId int,
    ArticuloId int,
    Articulo varchar(40),
    Descripcion varchar(max),
    Cantidad int,
    Monto money,       	        
);
go
create table Usuarios
(
	UsuariosId int primary Key identity(1,1),
	Nombre varchar(45),
	Usuario varchar(25),
	Contrase�a varchar(20),
	Tipodeusuario varchar(15)
);
go
insert into Usuarios(Nombre,Usuario,Contrase�a,Tipodeusuario) Values('Luis P�rez','root','123','Administrador');
go
create table Cobros
(
	CobroId int primary key Identity(1,1),
    Empe�oId int,
    Fecha Date,
    Abono money,
);
go
select *from Clientes
select *from Usuarios
Select *from Empe�osDetalle
Select *from Empe�os
select *from Cobros
select *from Articulos

truncate table Clientes
truncate table Cobros
truncate table Empe�osDetalle
truncate table Empe�os
truncate table Articulos