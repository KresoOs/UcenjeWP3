select top 10 sifra, ime, prezime from kupci;

-- koliko ima kupaca s Vašim imenom?

select * from kupci where ime='Tomislav';

-- Idete u svatove i želite kupiti poklon između 1000 i 2000 kn
-- Koliko artikala možete kupiti
select * from artikli where cijena between 130 and 260
and kratkinaziv like '%BUŠILICA%'
and kratkinaziv like '%BOSCH%';

-- izvršite konverziju u EUR-e
select count(*) from artikli;
update artikli set cijena = cijena/7.53450;


-- Koliko postoji primki?

select top 10 * from primke;

-- Na primci 

update ArtikliNaPrimci set cijena=cijena/7.53450;
-- Što je sve došlo na primci 7/2208
select 
d.naziv as dobavljac,
c.kratkiNaziv, b.cijena, b.kolicina, 
c.cijena-b.cijena as razlika
from Primke a
inner join ArtikliNaPrimci b on a.sifra=b.primka
inner join Artikli c on b.artikl=c.sifra
inner join Dobavljaci d on a.dobavljac=d.sifra
where a.redniBroj='7/2008';

