CREATE TABLE [dbo].[teAccounts] (
    [Id]      INT          NOT NULL,
    [PayeeId] INT          NOT NULL,
    [Number]  VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_teAccounts] PRIMARY KEY CLUSTERED ([Id] ASC)
);

