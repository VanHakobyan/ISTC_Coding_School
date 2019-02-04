CREATE DATABASE MyFirstDataBase

use MyFirstDataBase

create table People 
(
	Id int identity,
	FirstName nvarchar(250) not null,
	LastName nvarchar(250) not null,
	Age int null,
	Country varchar(150),
	City varchar(150),
	BirthDate datetime null,
	IsMarried bit not null
)


