-- =============================================
Create FUNCTION fn_GetLinkedinProfileAllInfoById(@Id int)
RETURNS TABLE 
AS
RETURN 
(
	select 
	       lp.*,
	       le.Time as WorkTime,
		   le.Location as WorkLocation,
		   le.Title as WorkTitle,
		   le.Company as WorkCompany,
		   led.Name EducationName,
		   LEd.Time EducationTime,
		   LEd.Title EducationTitle,
		   li.Name InterestName,
		   Li.FollowersCount InterestFollowersCount,
		   LL.Name LangugeName,
		   LS.Name SkillName,
		   LS.EndorsedCount
		   from LinkedinProfile LP
	join LinkedinExperience LE on LE.LinkedinProfileId = LP.Id
	join LinkedinEducation LEd on LEd.LinkedinProfileId=LP.Id
	join LinkedinInterest LI on LI.LinkedinProfileId=LP.Id
	join LinkedinLanguage LL on LL.LinkedinProfileId=LP.Id
	join LinkedinSkill LS on LS.LinkedinProfileId=LP.Id 
	where LP.id=@Id
)
GO

