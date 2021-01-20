
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-28 22:36:54.300
-- Description:	Update a claim
-- =============================================
CREATE PROCEDURE [dbo].[UpdateClaim] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@PatientId int, 
	@ProviderId int,
	@ClaimNumber varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[teClaims]
	SET  [PatientId] = @PatientId
		,[ProviderId] = @ProviderId
		,[ClaimNumber] = @ClaimNumber
	WHERE [Id] = @Id
END