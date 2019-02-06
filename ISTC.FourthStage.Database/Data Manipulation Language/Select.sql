select * from People 


select * from People 
where age is not null


select * from People 
where ismarried=0



select * from People 
where city is not null AND age between 10 and 30

select * from People 
where country is not null AND id in (1,19,2)


select * from People 
where country is not null OR City is null


select firstname from People 


select distinct lastname from People

select * from people where lastName like '%o%'


select * from people where lastName like 'C%'


select * from people where Country like 'Brazi_'


select top 2 * from people

select min(age) AS SmallestAge from people 

select count(*) from people

select AVG(Age) from people

select SUM(Age) from people


