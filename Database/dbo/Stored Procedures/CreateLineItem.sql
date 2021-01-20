
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-29 21:17:40.700
-- Description:	Create a line item
-- =============================================
CREATE PROCEDURE [dbo].[CreateLineItem] 
	-- Add the parameters for the stored procedure here
	@ClaimId int,
	@ServiceId int,
	@ServiceDate smalldatetime,
	@CopayAmount money,
	@OwedAmount money
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[teLineItems]
	(
		 [ClaimId]
		,[ServiceId]
		,[ServiceDate]
		,[CopayAmount]
		,[OwedAmount]
	)
	VALUES
	(
		 @ClaimId
		,@ServiceId
		,@ServiceDate
		,@CopayAmount
		,@OwedAmount
	)
END