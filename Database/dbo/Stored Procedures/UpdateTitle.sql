﻿
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-29 21:18:59.270
-- Description:	Update a title
-- =============================================
CREATE PROCEDURE [dbo].[UpdateTitle] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[tdTitles]
	SET [Name] = @Name
	WHERE [Id] = @Id
END