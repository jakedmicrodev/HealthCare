
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-29 22:14:31.305
-- Description:	Get title(s)
-- EXEC [dbo].[GetTitles] null, null
-- =============================================
CREATE PROCEDURE [dbo].[GetTitles] 
	-- Add the parameters for the stored procedure here
	@Id int = null, 
	@Name varchar(50) = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statementt.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		 t.[Id]
		,t.[Name]
		
	FROM [dbo].[tdTitles] t
	WHERE (@Id IS NULL OR t.[Id] = @Id) AND (@Name IS NULL OR t.[Name] = @Name)
	
END