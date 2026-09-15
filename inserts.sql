insert into korisnik(ime,prezime,br_telefona,email,adresa)
values('Admin','Test',067890890,'milenkobubamara@gmail.com','nmp345')

select * from korisnik

insert into kategorija(nazivkategorije)
values ('Ribice')

insert into kategorija(nazivkategorije)
values ('Hrana za ribice')

insert into kategorija(nazivkategorije)
values ('Pumpa')

insert into kategorija(nazivkategorije)
values ('Akvarijum')

select * from kategorija

insert into proizvod(naziv,cena,kolicinanastanju,opis,kategorija_id)
values ('Deni',1000,1,'Deni je jako interesantna ribica zelene boje. Ne ostavljajte ga samog!', 1)

insert into proizvod(naziv,cena,kolicinanastanju,opis,kategorija_id)
values ('larry',1000,1,'Larry je jedinstveni parrotfish. Odličan proiyvod!', 1)

insert into proizvod(naziv,cena,kolicinanastanju,opis,kategorija_id)
values ('Tetra mix',200,30,'Hrana za ribice', 2)

insert into proizvod(naziv,cena,kolicinanastanju,opis,kategorija_id)
values ('Pumpa za vodu',1500,10,'Pumpa', 2)

insert into proizvod(naziv,cena,kolicinanastanju,opis,kategorija_id)
values ('Akvarijum',10000,30,'dimenzija 120x40', 4)


select * from proizvod