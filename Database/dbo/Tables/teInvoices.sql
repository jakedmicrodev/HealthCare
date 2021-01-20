CREATE TABLE [dbo].[teInvoices] (
    [Id]            INT           NOT NULL,
    [LineItemId]    INT           NOT NULL,
    [PayeeId]       INT           NOT NULL,
    [AccountId]     INT           NOT NULL,
    [InvoiceNumber] VARCHAR (50)  NOT NULL,
    [Amount]        MONEY         NOT NULL,
    [DueDate]       SMALLDATETIME NOT NULL,
    CONSTRAINT [PK_teInvoices] PRIMARY KEY CLUSTERED ([Id] ASC)
);



