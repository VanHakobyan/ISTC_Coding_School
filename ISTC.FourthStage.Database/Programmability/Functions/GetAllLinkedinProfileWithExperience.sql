-- =============================================
CREATE FUNCTION fn_GetAllLinkedinProfileWithExperience()
RETURNS TABLE 
AS
RETURN 
(
	select 
	       lp.*,
	       le.Time as WorkTime,
		   le.Location as WorkLocation,
		   le.Title as WorkTitle,
		   le.Company as WorkCompany 
		   from LinkedinProfile LP
	join LinkedinExperience LE on LE.LinkedinProfileId = LP.Id
)
GO
