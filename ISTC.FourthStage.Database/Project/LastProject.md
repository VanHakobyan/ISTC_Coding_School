<img src='https://github.com/VanHakobyan/ISTC_Coding_School/blob/master/ISTC.FourthStage.Database/Project/diagram.png'>

1. Կառուցել համապատասխան բազա
2. Ավելացնել բազայում տրված տվյալները 
3. DbFirst մոտեցումով կառուցել օբյեկտային մոդել
 
 
 
 
### Genre <br>
				('G01', 'Action'),<br>
				('G02', 'Comedy'),<br>
				('G03', 'Thriller'),<br>
				('G04', 'Drama'),<br>
				('G05', 'Crime');<br>

### Director <br>
					('D01', 'Zack Snyder', 'American'),<br>
					('D02', 'Tim Miller', 'American'),<br>
					('D03', 'James Wan', 'Australian'),<br>
					('D04', 'Rajkumar Hirani', 'Indian'),<br>
					('D05', 'Ridley Scott', 'British'),<br>
					('D06', 'Todd Phillips', 'American'),<br>
					('D07', 'Sam Mendes', 'British'),<br>
					('D08', 'Christopher Nolan', 'British');<br>

### Movie <br>
    				('M01', 'Superman vs Batman', '2016-03-25', 'G01', 'D01'),<br>
    				('M02', 'Deadpool', '2016-02-12', 'G02', 'D02'),<br>
    				('M03', 'Furious 7', '2015-04-03', 'G03', 'D03'),<br>
    				('M04', 'PK', '2014-12-19', 'G04', 'D04'),<br>
    				('M05', 'Gladiator', '2000-05-05', 'G01', 'D05'),<br>
    				('M06', 'The Hangover', '2009-06-05', 'G02', 'D06'),<br>
    				('M07', '3 Idiots', '2009-12-25', 'G04', 'D04'),<br>
    				('M08', 'Spectre', '2015-11-06', 'G03', 'D07'),<br>
    				('M09', 'Batman Begins', '2005-06-15', 'G01', 'D08'),<br>
    				('M10', 'The Dark Knight', '2008-07-18', 'G05', 'D08');<br>
