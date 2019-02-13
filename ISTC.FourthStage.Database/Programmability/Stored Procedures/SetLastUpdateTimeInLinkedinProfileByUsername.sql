-- =============================================
CREATE PROCEDURE sp_SetLastUpdateTimeInLinkedinProfileByUsername(@username nvarchar(400))
AS
BEGIN
	update LinkedinProfile
	set LastUpdateTime=GETDATE()
	where Username=@username
END
GO
