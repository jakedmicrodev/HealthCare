CREATE TABLE [dbo].[teLineItems] (
    [Id]            INT           NOT NULL,
    [ClaimId]       INT           NULL,
    [ServiceId]     INT           NOT NULL,
    [ServiceDate]   SMALLDATETIME NOT NULL,
    [ExpenseTypeId] INT           NOT NULL,
    [CopayAmount]   MONEY         NULL,
    [OwedAmount]    MONEY         NULL,
    [ClaimNumber]   VARCHAR (50)  NULL,
    CONSTRAINT [PK_teLIneItems] PRIMARY KEY CLUSTERED ([Id] ASC)
);



