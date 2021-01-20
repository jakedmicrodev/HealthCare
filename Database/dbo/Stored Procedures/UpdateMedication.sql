
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-29 21:20:50.797
-- Description:	Update a medication
-- =============================================
CREATE PROCEDURE [dbo].[UpdateMedication] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[tdMedications]
	SET  [Name] = @Name
	WHERE [Id] = @Id
END