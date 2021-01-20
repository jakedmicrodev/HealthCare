

-- =============================================
-- Author:		Jake
-- Create date: 2020-11-02 21:46:05.753
-- Description:	Create a city
-- =============================================
CREATE PROCEDURE [dbo].[CreateCity] 
	-- Add the parameters for the stored procedure here
	@Name varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[tdCities]
	(
		[Name]
	)
	VALUES
	(
		@Name
	)
END