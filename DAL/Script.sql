create table Registros(
	RegistroId int identity(1,1) primary key,
	Razon varchar(30)
)

create table Materiales(
	Id int identity(1,1) primary key,
	RegitroId int references Registros(RegistroId),
	Material varchar(30),
	Cantidad int
)
