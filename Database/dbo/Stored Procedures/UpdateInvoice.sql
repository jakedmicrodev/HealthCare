
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-29 21:18:59.270
-- Description:	Update an invoice
-- =============================================
CREATE PROCEDURE [dbo].[UpdateInvoice] 
	-- Add the parameters for the stored procedure here
	@Id int,
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
	UPDATE [dbo].[teInvoices]
	SET  [LineItemId] = @LineItemId
		,[PayeeId] = @PayeeId
		,[AccountId] = @AccountId
		,[InvoiceNumber] = @InvoiceNumber
		,[Amount] = @Amount
		,[DueDate] = @DueDate
	WHERE [Id] = @Id
END