
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-28 22:36:54.300
-- Description:	Create a claim
--              EXEC [dbo].[CreateClaim] @PatientId, @ProviderId, @ClaimNumber
-- =============================================
CREATE PROCEDURE [dbo].[CreateClaim] 
	-- Add the parameters for the stored procedure here
	@PatientId int, 
	@ProviderId int,
	@ClaimNumber varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[teClaims]
	(
		 [PatientId]
		,[ProviderId]
		,[ClaimNumber]
	)
	VALUES
	(
		 @PatientId
		,@ProviderId
		,@ClaimNumber
	)
END