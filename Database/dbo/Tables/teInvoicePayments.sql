CREATE TABLE [dbo].[teInvoicePayments] (
    [Id]        INT      NOT NULL,
    [InvoiceId] INT      NOT NULL,
    [Amount]    MONEY    NOT NULL,
    [DatePaid]  DATETIME NOT NULL,
    CONSTRAINT [PK_teInvoicePayments] PRIMARY KEY CLUSTERED ([Id] ASC)
);

