create table Car
(
VIN varchar(50) primary key,
Model varchar(50) null,
Class varchar(50) null,
HP smallint null,
[Type] varchar(10),
OwnerId int,
FOREIGN KEY (OwnerId)  REFERENCES [Owner] (Id)
)
--drop table [owner] 
ALTER TABLE car
ADD FOREIGN KEY (OwnerId) REFERENCES [owner](id)

create table [Owner]
(
 Id int primary key identity, 
 [Name] nvarchar(200)
)

alter table Car
add Email varchar(200) not null UNIQUE 

alter table car
add check (HP>50)
