create view  v_GetCrossProfileUrls 
as
select GP.Url as GithubLink,'https://www.linkedin.com/in/'+lp.Username as LinkedinLink from GithubLinkedinCrossTable as CT
join GithubProfile Gp on gp.Id=ct.GithubUserId
join LinkedinProfile LP on lp.id=ct.LinkedinUserId


