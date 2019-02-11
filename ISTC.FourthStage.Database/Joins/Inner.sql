select top 100 GP.UserName,GR.Name from GithubProfile  as GP
inner join GithubRepository as GR on GP.Id=GR.ProfileId



select top 100 GP.UserName,GL.Name,Gl.[Percent] from GithubProfile  as GP
inner join GithubRepository as GR on GP.Id=GR.ProfileId
inner join GithubLanguage as GL on Gl.RepositoryId=GR.Id


select count(*) from GithubProfile  as GP
join GithubRepository as GR on GP.Id=GR.ProfileId

select top 10000 GP.UserName,GR.Name from GithubProfile  as GP
inner join GithubRepository as GR on GP.Id=GR.ProfileId

