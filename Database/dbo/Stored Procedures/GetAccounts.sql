
-- =============================================
-- Author:		Jake
-- Create date: now
-- Description:	Get account(s)
-- EXEC [dbo].[GetAccounts] null, null
-- =============================================
CREATE PROCEDURE [dbo].[GetAccounts] 
	-- Add the parameters for the stored procedure here
	@Id int = null, 
	@PayeeId int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		a.[Id] AS [Id]
		,a.[PayeeId]
		,IIF(p.[BusinessName] IS NULL, p.[FirstName] + IIF(p.[MI] IS NULL, ' ', ' ' + p.[MI] + ' ') + p.[LastName], p.[BusinessName]) AS [Payee]
		,a.[Number]		
	FROM [dbo].[teAccounts] a
	INNER JOIN [dbo].[tdPayees] p ON p.[Id] = a.[PayeeId]
	WHERE (@Id IS NULL OR a.[Id] = @Id) AND (@PayeeId IS NULL OR a.[PayeeId] = @PayeeId)
	ORDER BY [Payee], a.[Number]
END