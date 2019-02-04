alter table People 
add CreationDate datetime null

alter table People 
alter column Country varchar(300) 



----------------------Micosoft----------------------------------------
USE master
GO  
ALTER DATABASE MyFirstDataBase SET SINGLE_USER WITH ROLLBACK IMMEDIATE
GO
ALTER DATABASE MyFirstDataBase MODIFY NAME = MyFirstDataBaseModify 
GO  
ALTER DATABASE MyFirstDataBaseModify SET MULTI_USER
GO
