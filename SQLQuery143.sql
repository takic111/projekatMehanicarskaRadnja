create table automobil (
	Id int primary key not null identity(1,1),
	marka nvarchar(30) not null,
	model nvarchar(30) not null,
	vrstaUsluge nvarchar(50) not null,
)


create table vrstaUsluge (
	idUsluge int primary key identity(1,1) not null,
	imeUsluge nvarchar(50) not null,
	cenaUsluge int not null,
)

insert into vrstaUsluge (imeUsluge,cenaUsluge) values ('Veliki servis',35000)
insert into vrstaUsluge (imeUsluge,cenaUsluge) values ('Mali servis',5000)
insert into vrstaUsluge (imeUsluge,cenaUsluge) values ('Centriranje trapa',10000)
insert into vrstaUsluge (imeUsluge,cenaUsluge) values ('Zamena delova',20000)

create table radnik (
	Id int primary key not null identity(1,1),
	imePrezime nvarchar(50) not null,
	plata int not null,
)
