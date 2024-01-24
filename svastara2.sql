
-- Izvucite sve artikle, cijene i količine s primke
-- 1/2008
select c.kratkiNaziv,b.cijena,b.kolicina, 
b.cijena*b.kolicina as ukupno into moja
from Primke a
inner join ArtikliNaPrimci b on a.sifra=b.primka
inner join Artikli c		 on b.artikl = c.sifra
where a.redniBroj = '1/2008'
order by 1;

select *  from moja;

drop table moja;

select a.redniBroj, sum(b.cijena*b.kolicina) as ukupno 
from Primke a
inner join ArtikliNaPrimci b on a.sifra=b.primka
inner join Artikli c		 on b.artikl = c.sifra
where a.datum between '2008-01-01' and '2008-12-31'
group by a.redniBroj;

-- koji su dobavljači dobavili najveću vrijednost robe u 2008?
-- oni koji su prešli prag od milijun eur
select top 15 percent c.naziv, 
sum(b.cijena*b.kolicina) as ukupno,
min(b.cijena*b.kolicina) as minimalno,
max(cijena*b.kolicina) as maksimalno,
avg(b.cijena*b.kolicina) as prosjecno
from Primke a
inner join ArtikliNaPrimci b on a.sifra=b.primka
inner join Dobavljaci c		 on a.dobavljac = c.sifra
where a.datum between '2008-01-01' and '2008-12-31'
group by c.naziv
having sum(b.cijena*b.kolicina)>1000000
order by 5 desc;

-- funkcije
-- datumske
select datediff(Day,'2003-06-07 13:56:00',getdate())*24*60*70;

select dateadd(Day,-60,getdate());

-- matematičke
select power(2,3), sqrt(78), abs(-3), abs(3);

-- znakovne
select top 10 concat(trim(ime), ' ', trim(prezime)) as kupac from kupci;
drop function email;
-- kreiranje vlastite funkcije
CREATE FUNCTION email(
	@a varchar(50), @b varchar(50)
	)
RETURNS varchar(150) AS
BEGIN
    return concat(left(lower(@a),1), lower(
			replace(
			replace(
			replace(
			replace(
			replace(replace(upper(@b),' ',''),'Č','C')
			,'Š','S')
			,'Đ','D')
			,'Ć','C')
			,'Ž','Z')
			), '@edunova.hr');
END;

select top 10 dbo.email(ime,prezime), email from kupci;

update kupci set email = dbo.email(ime,prezime);

alter table kupci add rang int;

select top 10 * from kupci;

update kupci set rang = CAST(CRYPT_GEN_RANDOM(1) as int);

select rang, count(sifra) from kupci group by rang;

select cast(rand()*9+1 as int);

select CAST(CRYPT_GEN_RANDOM(1) as int)

alter table kupci alter column rang int not null;


-- Okidači (Triggers)
create table logiranje(
tko varchar(255),
sto varchar(255),
kada datetime default getdate()
);


CREATE TRIGGER kupac_unos
ON kupci
AFTER INSERT
AS
BEGIN
	insert into logiranje (tko,sto) 
	select 'Unos nove osobe', concat(ime, ' ', prezime) from inserted;

END


insert into kupci (ime,prezime, jmbg,rang)
values('Ana','Jurić','0252658596525',7);


select * from logiranje;


CREATE TRIGGER kupac_promjena
ON kupci
AFTER Update
AS
BEGIN
	insert into logiranje (tko,sto) 
	SELECT 'Promjena imena osobe', concat(trim(a.ime), ' - ', trim(b.ime))
      FROM Inserted a
      INNER JOIN Deleted b ON a.sifra = b.sifra;
END;

update kupci set ime='Anica' where sifra=471878;


select top 1 * from kupci order by sifra desc;


CREATE TRIGGER kupac_brisanje
ON kupci
AFTER delete
AS
BEGIN
	insert into logiranje (tko,sto) 
	SELECT 'Brisanje osobe', trim(ime) FROM Deleted;
END;


delete from kupci where sifra=471878;



-- procedure u SQL_dodatno_FOP



-- jedinstveni rezultati
select distinct ime from kupci;


-- podupiti

select count(*) from artikli;

select distinct artikl from ArtikliNaPrimci;


select * from artikli where sifra not in
(select distinct artikl from ArtikliNaPrimci);

delete from Artikli where sifra in (79102,90661);


