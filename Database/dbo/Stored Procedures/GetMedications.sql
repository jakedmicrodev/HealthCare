
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-29 22:12:59.265
-- Description:	Get medication(s)
-- EXEC [dbo].[GetMedications] null, null
-- =============================================
CREATE PROCEDURE [dbo].[GetMedications] 
	-- Add the parameters for the stored procedure here
	@Id int = null, 
	@Name varchar(50) = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		 m.[Id]
		,m.[Name]
		
	FROM [dbo].[tdMedications] m
	WHERE (@Id IS NULL OR m.[Id] = @Id) AND (@Name IS NULL OR m.[Name] = @Name)
	ORDER BY m.Name
	
END