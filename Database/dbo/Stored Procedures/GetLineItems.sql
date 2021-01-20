
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-30 20:42:25.152
-- Description:	Get line item(s)
-- EXEC [dbo].[GetLineItems] 1,
-- =============================================
CREATE PROCEDURE [dbo].[GetLineItems] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@ClaimId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statementp.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		 l.[Id]
		,l.[ClaimId]
		,l.[ServiceId]
		,s.[Name] AS [Service]
		,l.[ServiceDate]
		,l.[CopayAmount]
		,l.[OwedAmount]
	FROM [dbo].[teLineItems] l
	LEFT JOIN [dbo].[tdServices] s ON s.[Id] = l.[ServiceId]
	WHERE (@Id IS NULL OR l.[Id] = @Id) AND (@ClaimId IS NULL OR l.[ClaimId] = @ClaimId)
END