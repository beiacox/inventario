use today

go
create table articulos
	(
		ID int primary key,
		descripcion varchar(255) not null,
		existencia varchar(255),
		IDTPinventario int not null,
		costo int not null,
		estado varchar(25)

	)

go 

create table TPinventario

	(
		ID int primary key,
		descripcion varchar(255) not null,
		cuenta_contable varchar(255),
		estado varchar(25)
	)

go

create table Almacen
	(
		ID int primary key,
		descripcion varchar(255) not null,
		estado varchar(25)
	)

go

create table existenciasXalmacen
	(
		IDalmacen int not null,
		IDarticulo int not null,
		cantidad int
	)

go

create table transacciones
	(
		ID int primary key,
		Tipo varchar(15) not null,
		IDarticulo int not null,
		fecha datetime

	)