
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-29 21:18:59.270
-- Description:	Update a prescription
-- =============================================
CREATE PROCEDURE [dbo].[UpdatePrescription] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@MedicationId int,
	@LineItemId int,
	@Amount money
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[tePrescriptions]
	SET  [MedicationId] = @MedicationId
		,[LineItemId] = @LineItemId
		,[Amount] = @Amount
	WHERE [Id] = @Id
END