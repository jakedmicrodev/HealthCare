
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-30 21:07:40.855
-- Description:	Get prescription(s)
-- EXEC [dbo].[GetPrescriptions] null, null, null, null, null
-- =============================================
CREATE PROCEDURE [dbo].[GetPrescriptions] 
	-- Add the parameters for the stored procedure here
	@Id int = null, 
	@LineItemId int = null,
	@MedicationId int = null,
	@Amount decimal(5,2) = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		 p.[Id]
		,p.[LineItemId]
		,p.[MedicationId]
		,m.[Name] AS [Medication]
		,p.[Amount]		
	FROM [dbo].[tePrescriptions] p
	INNER JOIN [dbo].[tdMedications] m ON m.[Id] = p.[MedicationId]
	WHERE (@Id IS NULL OR p.[Id] = @Id) 
	AND (@MedicationId IS NULL OR p.[MedicationId] = @MedicationId)
	AND (@LineItemId IS NULL OR p.[LineItemId] = @LineItemId)
	AND (@Amount IS NULL OR p.[Amount] = @Amount)
	ORDER BY [Medication]
	
END