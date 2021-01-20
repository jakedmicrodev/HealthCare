-- =============================================
-- Author:		Jake
-- Create date: 2020-11-10 13:55:52.270
-- Description:	Get claims by service
-- =============================================
CREATE PROCEDURE [dbo].[GetClaimsByService] 
	-- Add the parameters for the stored procedure here
	@ServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		 c.[Id]
		,c.[PatientId]
		,p.[FirstName] + IIF(p.[MI] IS NULL, ' ', ' ' + p.[MI] + ' ') + p.[LastName] AS [Patient]
		,c.[ProviderId]
		,IIF(pr.[BusinessName] IS NULL, pr.[FirstName] + IIF(pr.[MI] IS NULL, ' ', ' ' + pr.[MI] + ' ') + pr.[LastName], pr.[BusinessName]) AS [Provider]
		,c.[ClaimNumber]		
	FROM [dbo].[teClaims] c
	LEFT JOIN [dbo].[tdPatients] p ON p.[Id] = c.[PatientId]
	LEFT JOIN [dbo].[tdProviders] pr ON pr.[Id] = c.[ProviderId]
	WHERE c.Id IN (
	SELECT [ClaimId]
	FROM [dbo].[teLineItems]
	WHERE [ServiceId] = @ServiceId)
END