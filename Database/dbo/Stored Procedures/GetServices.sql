
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-29 22:14:31.305
-- Description:	Get service(s)
-- EXEC [dbo].[GetServices] null, null
-- =============================================
CREATE PROCEDURE [dbo].[GetServices] 
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
		 s.[Id]
		,s.[Name]		
	FROM [dbo].[tdServices] s
	WHERE (@Id IS NULL OR s.[Id] = @Id) AND (@Name IS NULL OR s.[Name] = @Name)
	ORDER BY s.[Name]
END