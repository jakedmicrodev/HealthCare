
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-29 21:18:59.270
-- Description:	Create a prescription
-- =============================================
CREATE PROCEDURE [dbo].[CreatePrescription] 
	-- Add the parameters for the stored procedure here
	@MedicationId int,
	@LineItemId int,
	@Amount money
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[tePrescriptions]
	(
		 [MedicationId]
		,[LineItemId]
		,[Amount]
	)
	VALUES
	(
		 @MedicationId
		,@LineItemId
		,@Amount
	)
END