CREATE TABLE [dbo].[tdPatients] (
    [Id]        INT          NOT NULL,
    [FirstName] VARCHAR (50) NOT NULL,
    [MI]        NCHAR (1)    NULL,
    [LastName]  VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tdPatients] PRIMARY KEY CLUSTERED ([Id] ASC)
);



