
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-30T21:20:18.782
-- Description:	Get invoice(s)
-- EXEC [dbo].[GetInvoices] 118, null, null, null, null, null, null
-- =============================================
CREATE PROCEDURE [dbo].[GetInvoices] 
	-- Add the parameters for the stored procedure here
	@Id int = null, 
	@LineItemId int = null,
	@PayeeId int = null,
	@AccountId int = null,
	@InvoiceNumber varchar(50) = null,
	@Amount money = null,
	@DueDate smalldatetime = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		 i.[Id]
		,i.[LineItemId]
		,i.[PayeeId]
		,IIF(p.[BusinessName] IS NULL, p.[FirstName] + IIF(p.[MI] IS NULL, ' ', ' ' + p.[MI] + ' ') + p.[LastName], p.[BusinessName]) AS [Payee]
		,i.[AccountId]
		,a.[Number] AS [AccountNumber]
		,i.[InvoiceNumber]
		,i.[Amount]		
		,i.[DueDate]
	FROM [dbo].[teInvoices] i
	LEFT JOIN [dbo].[teLineItems] l ON l.[Id] = i.[LineItemId]
	LEFT JOIN [dbo].[tdPayees] p ON p.[Id] = i.[PayeeId]
	LEFT JOIN [dbo].[teAccounts] a ON a.[Id] = i.[AccountId]
	WHERE (@Id IS NULL OR i.[Id] = @Id) 
	AND (@LineItemId IS NULL OR i.[LineItemId] = @LineItemId)
	AND (@PayeeId IS NULL OR i.[PayeeId] = @PayeeId)
	AND (@AccountId IS NULL OR i.[AccountId] = @AccountId)
	
END