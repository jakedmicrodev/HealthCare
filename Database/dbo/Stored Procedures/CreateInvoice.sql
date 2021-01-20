
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-29 21:18:59.270
-- Description:	Create an invoice
-- =============================================
CREATE PROCEDURE [dbo].[CreateInvoice] 
	-- Add the parameters for the stored procedure here
	@LineItemId int,
	@PayeeId int,
	@AccountId int,
	@InvoiceNumber varchar(50),
	@Amount money,
	@DueDate smalldatetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[teInvoices]
	(
		 [LineItemId]
		,[PayeeId]
		,[AccountId]
		,[InvoiceNumber]
		,[Amount]
		,[DueDate]
	)
	VALUES
	(
		 @LineItemId
		,@PayeeId
		,@AccountId
		,@InvoiceNumber
		,@Amount
		,@DueDate
	)
END