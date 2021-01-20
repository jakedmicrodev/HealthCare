

-- =============================================
-- Author:		Jake
-- Create date: 2020-11-02 21:43:39.560
-- Description:	Get states
-- EXEC [dbo].[GetStates] null, null
-- =============================================
CREATE PROCEDURE [dbo].[GetStates] 
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
		
	FROM [dbo].[tdStates] s
	WHERE (@Id IS NULL OR s.[Id] = @Id) AND (@Name IS NULL OR s.[Name] = @Name)
	ORDER BY s.Name
	
END