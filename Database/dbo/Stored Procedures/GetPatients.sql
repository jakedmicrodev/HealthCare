
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-29 22:26:34.804
-- Description:	Get patient(s)
-- EXEC [dbo].[GetPatients] null, null
-- =============================================
CREATE PROCEDURE [dbo].[GetPatients] 
	-- Add the parameters for the stored procedure here
	@Id int = null, 
	@FirstName varchar(50) = null,
	@MI nchar(1) = null,
	@LastName varchar(50) = null
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
		,p.[FirstName] + IIF(p.[MI] IS NULL, ' ', ' ' + p.[MI] + ' ') + p.[LastName] AS [Name]
	FROM [dbo].[tdPatients] p
	WHERE (@Id IS NULL OR p.[Id] = @Id) 
	AND (@FirstName IS NULL OR p.[FirstName] = @FirstName)
	AND (@MI IS NULL OR p.[MI] = @MI)
	AND (@LastName IS NULL OR p.[LastName] = @LastName)
	
END