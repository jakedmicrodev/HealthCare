
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-29 21:18:59.270
-- Description:	Create a title
-- =============================================
CREATE PROCEDURE [dbo].[CreateTitle] 
	-- Add the parameters for the stored procedure here
	@Name varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[tdTitles]
	(
		[Name]
	)
	VALUES
	(
		@Name
	)
END