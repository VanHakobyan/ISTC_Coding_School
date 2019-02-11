select top 10000 GP.UserName,GR.Name from GithubProfile as GP
left join GithubRepository as GR on GP.Id=GR.ProfileId

