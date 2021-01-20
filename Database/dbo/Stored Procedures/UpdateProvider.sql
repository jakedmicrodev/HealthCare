
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-29 21:18:59.270
-- Description:	Update a provider
-- =============================================
CREATE PROCEDURE [dbo].[UpdateProvider] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@BusinessName varchar(50) = null,
	@FirstName varchar(50) = null,
	@MI nchar(1) = null,
	@LastName varchar(50) = null,
	@TitleId int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[tdProviders]
	SET  [BusinessName] = @BusinessName
		,[FirstName] = @FirstName
		,[MI] = @MI
		,[LastName] = @LastName
		,[TitleId] = @TitleId
	WHERE [Id] = @Id
END