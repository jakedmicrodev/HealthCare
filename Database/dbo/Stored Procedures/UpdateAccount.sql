
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-29 21:18:59.270
-- Description:	Update an account
-- =============================================
CREATE PROCEDURE [dbo].[UpdateAccount] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@PayeeId int,
	@Number varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[teAccounts]
	SET  [PayeeId] = @PayeeId
		,[Number] = @Number
	WHERE [Id] = @Id
END