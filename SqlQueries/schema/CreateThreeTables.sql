create database studentdata
use studentdata
create table tblBodyMessage (Id int primary key identity(1,1));
Alter table tblEmailMessage add  BodyMessageId Int foreign key references tblBodyMessage(Id)
Alter table tblBodyMessage add constraint tblBodyMessage_BDM_Id_FK
FOREIGN KEY (Id) references tblEmailMessage (Id)

FOREIGN KEY (Country_id) references country (country_id)
Select tblUsers.Email From tblUsers
select DOS from tblEmailMessage where Sender='vasilis'
select * from tblUsers
delete from tblUsers where Password= 'pass1'
Select DISTINCT Roles from tblUsers
EXEC sp_rename 'tblUsers.UserName','Email','COLUMN'

select tblEmailMessage.DataMessage from tblEmailMessage 

Alter table tblcity drop Constraint tblCity_Country_Id_FK
select a.FNanme, a.LName,a.id, b.Email,b.Roles, b.UserId
from tblStudentInfo a,tblUsers b
where 
a.Email = b.Email
delete  from tblEmailMessage where Id=15
create table tblEmailMessage
(
Id int identity(1,1) Primary Key,
Sender nvarchar(50) not null, 
Receiver nvarchar(50) not null,
DataMessage nvarchar(50),
DOS nvarchar(50) not null,

);
UPDATE tblEmailMessage  SET
		DataMessage = 'This is a test CCCCCCC'
		where tblEmailMessage.Id in( select tblEmailMessage.Id from tblEmailMessage where Sender= 'admin'and DataMessage='this is a test')
select *from tblEmailMessage.DataMessage from tblEmailMessage where sender= 'admin'  and Id=2
UPDATE tblEmailMessage  SET DataMessage = 'This is a test3' where id= 3
where tblEmailMessage.Sender= 'admin' and id =
select tblEmailMessage.DataMessage from tblEmailMessage where sender = 'admin'
select tblEmailMessage.Id from tblEmailMessage where Sender= 'admin' and DataMessage='this is a test'
select id from tblEmailMessage where Sender = 'admin'
select* from tblUsers
Select tblEmailMessage.Sender,  tblEmailMessage.Receiver,tblEmailMessage.DOS, tblEmailMessage.DataMessage from 
tblEmailMessage
where Sender = 'admin'
select *from tblEmailMessage
select Id from tblEmailMessage where DOS ='07/01/2019 07:02:48' AND Sender= 'vasilis'
ALTER TABLE tblEmailMessage
ADD MSDOS DATETIME2(3) NOT NULL DEFAULT (GETDATE());
-- Drop Column
alter table tblEmailMessage
drop column  DDOSN;
select * from tblStudentInfo

select tblEmailMessage.Sender,  tblEmailMessage.Receiver,tblEmailMessage.DOS, tblEmailMessage.DataMessage
from tblEmailMessage
where Receiver = 'Papadatos'


select tblStudentInfo.FNanme, tblStudentInfo.LName, tblcity.CityName 
from tblStudentInfo
inner join tblcity
on tblStudentInfo.Country_Id = tblcity.Country_id

select* from tblStudentInfo
select * from tblUsers

--Bring All of Registered Users that have create Student Profile
select tblStudentInfo.LName from tblStudentInfo
inner join tblUsers
on tblStudentInfo.Email= tblUsers.Email

alter table province


select * from tblcity

EXEC sp_fkeys 'city'
ALTER AUTHORIZATION ON DATABASE::studentdata TO sa;
GO

select * from tblcity where Country_id =1
select * from tblprovince

select * from tblprovince where City_id =5

create table
(
MessageId Int not null
)


Update tblClass
Set ClassName = 'Select Class'
Where Id = 1

select * from tblClass



select * from tblStudentInfo

select tblStudentInfo.id, tblStudentInfo.FNanme,tblStudentInfo.LName,tblStudentInfo.FatherName,tblStudentInfo.FatherId,tblStudentInfo.Email,tblStudentInfo.Mobile,tblStudentInfo.DOBirth,tblStudentInfo.DORegistration,tblClass.ClassName,tblStudentInfo.Adress,tblStudentInfo.gender,country.CountryName,tblprovince.ProvinceName,tblcity.CityName
from tblStudentInfo
inner join tblClass
on tblStudentInfo.Class_Id = tblClass.Id
inner join country
on tblStudentInfo.Country_Id = country.country_id
inner join tblprovince
on tblStudentInfo.Prov_Id= tblprovince.Id
inner join tblcity
on tblStudentInfo.City_Id = tblcity.Id

select tblStudentInfo.id, tblStudentInfo.FNanme,tblStudentInfo.LName,tblStudentInfo.FatherName,tblStudentInfo.FatherId,tblStudentInfo.Email,tblStudentInfo.Mobile,tblStudentInfo.DOBirth,tblStudentInfo.DORegistration,tblClass.ClassName,tblStudentInfo.Adress,tblStudentInfo.gender,country.CountryName,tblprovince.ProvinceName,tblcity.CityName from tblStudentInfo inner join tblClass on tblStudentInfo.Class_Id = tblClass.Id inner join country on tblStudentInfo.Country_Id = country.country_id inner join tblprovince on tblStudentInfo.Prov_Id = tblprovince.Id inner join tblcity on tblStudentInfo.City_Id = tblcity.Id

Update tblStudentInfo
Set id = 1
Where id = 1

Select tblEmailMessage.Sender,  tblEmailMessage.Receiver,tblEmailMessage.DOS, tblEmailMessage.DataMessage from tblEmailMessage where Sender = 'admin'

select * from tblBodyMessage
select * from tblEmailMessage
select * from tblUsers
alter table tblUsers drop constraint tblUsers_Roles_Id_FK
alter table tblEmailMessage drop constraint FK__tblEmailM__BodyM__703EA55A



