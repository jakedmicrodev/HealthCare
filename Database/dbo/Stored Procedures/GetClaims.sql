
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-29 22:09:20.983
-- Description:	Get claim(s)
-- EXEC [dbo].[GetClaims] null, null, null, null
-- =============================================
CREATE PROCEDURE [dbo].[GetClaims] 
	-- Add the parameters for the stored procedure here
	@Id int = null, 
	@PatientId int = null,
	@ProviderId int = null,
	@ClaimNumber varchar(50) = null
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
	WHERE (@Id IS NULL OR c.[Id] = @Id) 
	AND (@PatientId IS NULL OR c.[PatientId] = @PatientId)
	AND (@ProviderId IS NULL OR c.[ProviderId] = @ProviderId)
	AND (@ClaimNumber IS NULL OR c.[ClaimNumber] = @ClaimNumber)
	
END