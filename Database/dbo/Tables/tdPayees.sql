CREATE TABLE [dbo].[tdPayees] (
    [Id]            INT          NOT NULL,
    [BusinessName]  VARCHAR (50) NULL,
    [FirstName]     VARCHAR (50) NULL,
    [MI]            NCHAR (1)    NULL,
    [LastName]      VARCHAR (50) NULL,
    [TitleId]       INT          NULL,
    [Address1]      VARCHAR (50) NOT NULL,
    [Address2]      VARCHAR (50) NULL,
    [CityId]        INT          NOT NULL,
    [StateId]       INT          NOT NULL,
    [Zip]           NCHAR (9)    NULL,
    [Phone]         NCHAR (10)   NULL,
    [NameOnAccount] VARCHAR (50) NOT NULL,
    [ActiveCD]      BIT          NOT NULL,
    CONSTRAINT [PK_tdPayees] PRIMARY KEY CLUSTERED ([Id] ASC)
);



