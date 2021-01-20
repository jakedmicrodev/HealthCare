
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-29 21:20:50.797
-- Description:	Create a medication
-- =============================================
CREATE PROCEDURE [dbo].[CreateMedication] 
	-- Add the parameters for the stored procedure here
	@Name varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[tdMedications]
	(
		[Name]
	)
	VALUES
	(
		@Name
	)
END