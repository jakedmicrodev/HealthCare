

-- =============================================
-- Author:		Jake
-- Create date: 2020-11-02 21:46:05.753
-- Description:	Create a state
-- =============================================
CREATE PROCEDURE [dbo].[CreateState] 
	-- Add the parameters for the stored procedure here
	@Name varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[tdStates]
	(
		[Name]
	)
	VALUES
	(
		@Name
	)
END