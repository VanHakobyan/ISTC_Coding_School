drop table People

use master
ALTER DATABASE MyFirstDataBase SET SINGLE_USER WITH ROLLBACK IMMEDIATE
GO
drop database MyFirstDataBase
