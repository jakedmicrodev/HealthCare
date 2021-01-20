
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-30 20:51:25.606
-- Description:	Get payee(s)
-- EXEC [dbo].[GetPayees] null
-- =============================================
CREATE PROCEDURE [dbo].[GetPayees] 
	-- Add the parameters for the stored procedure here
	@Id int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statementp.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		 p.[Id]
		,p.[FirstName]
		,p.[MI]
		,p.[LastName]
		,p.[BusinessName]
		,IIF(p.[BusinessName] IS NULL, p.[FirstName] + IIF(p.[MI] IS NULL, ' ', ' ' + p.[MI] + ' ') + p.[LastName], p.[BusinessName]) AS [Name]
		,p.[TitleId]
		,t.[Name] AS [Title]
		,p.Address1
		,p.Address2
		,p.CityId
		,c.Name AS [City]
		,p.StateId
		,s.Name AS [State]
		,p.Phone
		,p.Zip
	FROM [dbo].[tdPayees] p
	LEFT JOIN [dbo].[tdTitles] t ON t.[Id] = p.[TitleId]
	LEFT JOIN [dbo].[tdCities] c ON c.[Id] = p.[CityId]
	LEFT JOIN [dbo].[tdStates] s ON s.[Id] = p.[StateId]
	WHERE (@Id IS NULL OR p.[Id] = @Id)
	ORDER BY [Name]
END