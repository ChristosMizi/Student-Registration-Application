create database studentdata

create table country(country_id int primary key identity(1,1),CountryName varchar(50))
create table tblcity(Id int primary key identity(1,1), CityName varchar(50),Country_id int)
Alter table tblcity add constraint tblCity_Country_Id_FK
FOREIGN KEY (Country_id) references country (country_id)
create table tblprovince(Id int primary key identity(1,1), ProvinceName varchar(50), City_id int foreign key references tblcity(Id))
create table tblClass
(
	Id int identity (1,1) Primary Key , 
	ClassName varchar(50)
);

create table tblStudentInfo
(
	id int primary key identity(1,1) references tblUsers(UserId),
	FNanme varchar(50),
	LName varchar(50),
	FatherName varchar(50),
	FatherId varchar  (50),
	Email varchar  (50),
	Mobile varchar  (50),
	DOBirth varchar  (50),
	DORegistration varchar  (50),
	Class_Id int Foreign Key references tblClass(Id),
	Adress varchar(50),
	gender varchar(50),
	Country_Id int foreign key references Country(country_id),
	Prov_Id int foreign key references tblprovince(Id),
	City_Id Int foreign Key references tblcity(Id)
);

ALTER TABLE tblStudentInfo ALTER COLUMN Email varchar (50) NOT NULL
Alter Table tblStudentInfo ADD Email_Id Int foreign key references tblEmailMessage(Id)

-- Create Table StatusMsg 
create table StatusMsg
(
	Id int primary key identity(1,1),
	Status varchar(50)
);

--create table Registered users
create table tblUsers
(
UserId int  not null identity(1,1),
Email nvarchar(50) Primary Key,
Password nvarchar(50),
Description nvarchar(max) not null,
Roles_Id int 

)
insert into tblUsers (Email) Values ('admin')
insert into tblUsers ([Password]) Values ('admin')
insert into tblUsers (Roles) Values ('Super Admin')


insert into country values ('Choose Country'),('Greece'),('UK'),('Netherlands'),('Ireland')


insert into tblcity (CityName,Country_id) values ('Choose City',1),('Kavala',2),('Thesaloniki',2),('Iwannina',2),('Patra',2),('Athina',2)
insert into tblcity (CityName,Country_id) values ('Bedfordshire',3),('Bristol',3),('Cambridgeshire',3),('Essex',3),('Hampshire',3),('Norfolk',3)


insert into tblprovince (ProvinceName,City_id) values	('Choose Province',1),('Pefki',6),('Marousi',6),('Xalandri',6),('Kiffisia',6),('Nea.Eruthrea',6)
insert into tblprovince (ProvinceName,City_id) values ('Anw Toumpa',3),('Efxinoupoli',3),('Ladadika',3),('Ntepw',3),('Stavroupoli',3)


insert into tblClass (ClassName) values('Choose Class')
insert into tblClass (ClassName) values('Eisagwgi stin Politiki Oikonomia')
insert into tblClass (ClassName) values('Logistiki I')
insert into tblClass (ClassName) values('Mikrooikonomiki Thewria I')
insert into tblClass (ClassName) values('Oikonometria I')
insert into tblClass (ClassName) values('Arxes Oikonomikis Analusis')
insert into tblClass (ClassName) values('Diethnis Oikonomiki')
select * from tblClass

create table Roles
(
	Id int primary key identity (1,1),
	Roles nvarchar(50)
)
Alter table tblUsers add Roles_Id int 
Alter table tblUsers add constraint tblUsers_Roles_Id_FK FOREIGN KEY (Roles_Id) references Roles (Id)

alter table tblStudentInfo add constraint tblStudentInfo_Email_FK
FOREIGN KEY (Email) references tblUsers (Email)


insert into StatusMsg ([Status]) Values('Read')
insert into StatusMsg (Status) Values('Unread')



