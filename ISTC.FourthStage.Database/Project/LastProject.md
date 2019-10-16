<img src='https://github.com/VanHakobyan/ISTC_Coding_School/blob/master/ISTC.FourthStage.Database/Project/diagram.png'>

1. Կառուցել համապատասխան բազա
2. Ավելացնել բազայում տրված տվյալները 
3. DbFirst մոտեցումով կառուցել օբյեկտային մոդել
 
 
 
 
Genre 
				('G01', 'Action'),
				('G02', 'Comedy'),
				('G03', 'Thriller'),
				('G04', 'Drama'),
				('G05', 'Crime');

Director 
					('D01', 'Zack Snyder', 'American'),
					('D02', 'Tim Miller', 'American'),
					('D03', 'James Wan', 'Australian'),
					('D04', 'Rajkumar Hirani', 'Indian'),
					('D05', 'Ridley Scott', 'British'),
					('D06', 'Todd Phillips', 'American'),
					('D07', 'Sam Mendes', 'British'),
					('D08', 'Christopher Nolan', 'British');

Movie 
    				('M01', 'Superman vs Batman', '2016-03-25', 'G01', 'D01'),
    				('M02', 'Deadpool', '2016-02-12', 'G02', 'D02'),
    				('M03', 'Furious 7', '2015-04-03', 'G03', 'D03'),
    				('M04', 'PK', '2014-12-19', 'G04', 'D04'),
    				('M05', 'Gladiator', '2000-05-05', 'G01', 'D05'),
    				('M06', 'The Hangover', '2009-06-05', 'G02', 'D06'),
    				('M07', '3 Idiots', '2009-12-25', 'G04', 'D04'),
    				('M08', 'Spectre', '2015-11-06', 'G03', 'D07'),
    				('M09', 'Batman Begins', '2005-06-15', 'G01', 'D08'),
    				('M10', 'The Dark Knight', '2008-07-18', 'G05', 'D08');
