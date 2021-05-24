CREATE DATABASE Tiendadb
GO
USE Tiendadb
GO
CREATE TABLE Cliente (
id_cliente int Primary key IDENTITY (1,1),
nombre varchar(60), 
apellido varchar(60), 
direccion varchar(60),
fecha_nacimiento varchar(20),
telefono varchar(10),
email varchar(60),
)
GO
CREATE TABLE Modo_Pago (
num_pago int Primary key IDENTITY(1,1),
nombre varchar(60), 
otros_detalles varchar(60),
)
GO
CREATE TABLE Factura (
id_factura int Primary Key IDENTITY(1,1),
num_factura varchar(150),
id_cliente int,
fecha varchar(15),
num_pago int,
FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente),
FOREIGN KEY (num_pago) REFERENCES Modo_Pago (num_pago))
GO
CREATE TABLE Categoria(
id_categoria int Primary Key IDENTITY(1,1), 
nombre varchar(30), 
descripcion varchar (120),
) 
GO
CREATE TABLE Producto(
id_producto int Primary key IDENTITY, 
nombre varchar(50), 
precio money, 
stock int, 
id_categoria int,
FOREIGN KEY (id_categoria) REFERENCES Categoria(id_categoria))
GO
CREATE TABLE Detalle(
num_detalle int primary key IDENTITY(1,1),
id_factura  int ,
id_producto int,
cantidad int,
precio money,
FOREIGN KEY (id_producto) REFERENCES Producto(id_Producto),
FOREIGN KEY (id_factura) REFERENCES Factura(id_factura)
)
GO

USE Tiendadb
go
insert into Cliente([nombre],[apellido],[direccion],[fecha_nacimiento],[telefono],[email]) values('Mauricio','Guardado','Col ivu','07/30/00','24405302','Karambanos@yopmail.com')
insert into Cliente([nombre],[apellido],[direccion],[fecha_nacimiento],[telefono],[email]) values('Gaby','Alas','Col Santa Lucia','16/02/00','24409089','Gabytio@yopmail.com')
go

insert into Modo_Pago([nombre],[otros_detalles] )values('Efectivo','Pagado en caja')
insert into Modo_Pago([nombre],[otros_detalles] )values('Tarjeta','Banco Cuscatlan')
go

insert into Factura([id_cliente],[num_factura],[fecha],[num_pago]) values(1,'Compra de telefono','17/05/21',1)
insert into Factura([id_cliente],[num_factura],[fecha],[num_pago]) values(2,'Compra Venta de vienes','15/02/14',2)

insert into Categoria([nombre],[descripcion]) Values('Monitor','Componente LCD')
insert into Categoria([nombre],[descripcion]) Values('Nintendo','Consola')

insert into Producto([nombre],[precio],[stock],[id_categoria]) Values('AOC',120,10,1)
insert into Producto([nombre],[precio],[stock],[id_categoria]) Values('Switch',300,30,2)

insert into Detalle([id_factura],[id_producto],[cantidad],[precio]) Values (1,1,2,240)
insert into Detalle([id_factura],[id_producto],[cantidad],[precio]) Values (2,2,3,900)

select*from Cliente
select*from Modo_Pago
select*from Factura
select*from Categoria
select*from Producto
select*from Detalle