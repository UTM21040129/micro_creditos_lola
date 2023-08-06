create database micro_creditos;
use micro_creditos;

create table contactos(
	id_contacto int primary key identity,
	email nvarchar(200) not null,
	telefono nvarchar(32)
);

create table clientes(
	id_cliente int primary key identity,
	nombre nvarchar(150) not null,
	apellido_paterno nvarchar(50) not null,
	apellido_materno nvarchar(50) not null,
	id_contacto int,
	foreign key (id_contacto) references contactos(id_contacto)
);

create table prestamos(
	id_prestamo int primary key identity,
	id_cliente int,
	fecha_prestamo datetime,
	cantidad_prestada decimal(6,2) not null,
	/*dia_cobro int,*/
	meses_prestamo int,
	interes smallint,
	estado bit,
	foreign key (id_cliente) references clientes(id_cliente)
);

create table pagos(
	id_pago int primary key identity,
	id_prestamo int,
	numero_pago int,
	fecha_pago datetime,
	monto decimal(6,2) not null,
	foreign key (id_prestamo) references prestamos(id_prestamo)
);

insert into contactos values ('b0mbom44@gmail.com','4494593965'),('danielamacias144@gmail.com','4495659152');

select * from contactos;

insert into clientes values ('Javier','Gonzalez','Huerta',1),('Daniela','Macias','Rocha',2);

select * from clientes;

insert into prestamos values (1,'2023-07-30 10:00:00',1500.00,6,10,1),(2,'2023-07-30 11:00:00',3500.00,12,10,1);

select * from prestamos;

insert into pagos values (1,1,'2023-08-30 14:14:56',250),(1,2,'2023-09-30 14:14:56',250),(2,1,'2023-09-30 14:14:56',291.66);

select * from pagos;