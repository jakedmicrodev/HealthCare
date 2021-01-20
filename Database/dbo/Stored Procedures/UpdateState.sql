

-- =============================================
-- Author:		Jake
-- Create date: 2020-11-02 21:48:02.260
-- Description:	Update a state
-- =============================================
CREATE PROCEDURE [dbo].[UpdateState] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[tdStates]
	SET  [Name] = @Name
	WHERE [Id] = @Id
END