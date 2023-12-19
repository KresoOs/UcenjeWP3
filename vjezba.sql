create table zaposlenici(
sifra int not null primary key identity(1,1),
ime varchar (50),
prezime varchar (50),
datumrodjenja datetime,
placa decimal(18,2),
invalid bit,
);
create table slike(
sifra int not null primary key identity(1,1),
zaposlenik int not null,
rednibroj int,
putanja varchar(100),

);

alter table slike add foreign key (zaposlenik) references zaposlenici (sifra);

insert into zaposlenici (ime,prezime,datumrodjenja,placa,invalid) values
('Goran','Cutuk',1987-04-15,800.00,0);

insert into slike (zaposlenik,rednibroj,putanja)
values(1,1,'putanja1'),(1,2,'putanja2'),
(2,1,'putanja1'),(2,2,'putanja2'),
(3,1,'putanja1'),(3,2,'putanja2');
select * from slike;

use master
create database webshop
use webshop

create table proizvodi(
sifra int not null primary key identity(1,1),
naziv varchar(100),
datumnabave datetime,
cijena decimal (18,2),
aktivan bit,
);
create table racuni(
sifra int not null primary key identity(1,1),
datum datetime,
kupac int,
placeno bit,
);
create table kupci (
sifra int not null primary key identity(1,1),
ime varchar(50),
prezime varchar(50),
ulica varchar(50),
mjesto varchar(50),
);
create table stavke(
racun int,
proizvod int,
kolicina decimal(18,2),
cijena decimal(18,2),
);
alter table stavke add foreign key (racun) references racuni(sifra);
alter table stavke add foreign key (proizvod) references proizvodi(sifra);
alter table racuni add foreign key (kupac) references kupci(sifra);

insert into kupci (ime,prezime,ulica,mjesto) values
('Miki','Manojlović','Duga 23','Veliškovci'),