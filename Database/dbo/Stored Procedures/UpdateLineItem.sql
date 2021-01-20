
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-29 21:17:40.700
-- Description:	Update a line item
-- =============================================
CREATE PROCEDURE [dbo].[UpdateLineItem] 
	-- Add the parameters for the stored procedure here
	@Id int,
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
	UPDATE [dbo].[teLineItems]
	SET  [ClaimId] = @ClaimId
		,[ServiceId] = @ServiceId
		,[ServiceDate] = @ServiceDate
		,[CopayAmount] = @CopayAmount
		,[OwedAmount] = @OwedAmount
	WHERE [Id] = @Id
END