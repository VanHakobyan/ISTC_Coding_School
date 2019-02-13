-- =============================================
CREATE PROCEDURE sp_SetLastUpdateTimeInLinkedinProfileByUsername(@username nvarchar(400))
AS
BEGIN
	update LinkedinProfile
	set LastUpdate=GETDATE()
	where Username=@username
END
GO
