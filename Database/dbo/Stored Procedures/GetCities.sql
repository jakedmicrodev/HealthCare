

-- =============================================
-- Author:		Jake
-- Create date: 2020-11-02 21:43:39.560
-- Description:	Get cities
-- EXEC [dbo].[GetCities] null, null
-- =============================================
CREATE PROCEDURE [dbo].[GetCities] 
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
		 c.[Id]
		,c.[Name]
		
	FROM [dbo].[tdCities] c
	WHERE (@Id IS NULL OR c.[Id] = @Id) AND (@Name IS NULL OR c.[Name] = @Name)
	ORDER BY c.Name
	
END