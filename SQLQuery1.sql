create database Petshop

create table korisnik(
Korsnik_id int identity(1,1) primary key,
ime varchar(100) not null,
prezime varchar(100) not null,
br_telefona int not null,
email varchar(100) not null,
adresa varchar(100) not null

)

create table proizvod(
Proizvod_id int identity(1,1) primary key,
naziv varchar(100) not null,
cena decimal(10,2) not null,
kolicinanastanju int not null,
opis varchar(500) null,
kategorija_id int  not null
)

create table kategorija(
kategorija_id int identity(1,1) Primary key,
nazivkategorije varchar(100) not null
)

Alter table proizvod
add constraint  FK_KATEGORIJA foreign key (kategorija_id)
REFERENCES kategorija (kategorija_id);

drop table proizvod

create table porudzbina(
porudzbina_id int identity (1,1) primary key,
Korsnik_id int not null,
Datumporudzbine datetime not null,
ukupnacena decimal(10,2) not null,
status varchar(100) not null
)

Alter table porudzbina
add constraint  FK_Korisnik foreign key (Korsnik_id)
REFERENCES korisnik (Korsnik_id);

create table stavkaporudzbine(
stavkaporudzbine_id int identity(1,1) primary key,
porudzbina_id int not null,
Proizvod_id int not null,
kolicina int not null,
cena decimal(10,2) not null
)

Alter table  stavkaporudzbine
add constraint  FK_stavkaporudzbine foreign key (porudzbina_id)
REFERENCES porudzbina (porudzbina_id);

Alter table  stavkaporudzbine
add constraint  FK_stavkaproizvoda foreign key (Proizvod_id)
REFERENCES proizvod (Proizvod_id);

alter table korisnik
add lozinka Nvarchar(255)  

Update korisnik
set lozinka ='test123'
where Korsnik_id = 1;

select * from korisnik