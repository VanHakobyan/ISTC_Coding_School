SELECT firstname,count(firstname) as CountInTable FROM People
group by firstname


SELECT firstname,count(firstname) as CountInTable FROM People
group by firstname
having FirstName like 'J%'


SELECT firstname,count(firstname) as CountInTable FROM People
group by firstname
HAVING COUNT(*)>1




SELECT firstname,MAX(age) as MaxAge FROM People
group by firstname
HAVING min(age)>3