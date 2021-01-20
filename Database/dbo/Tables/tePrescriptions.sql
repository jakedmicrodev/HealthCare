CREATE TABLE [dbo].[tePrescriptions] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [LineItemId]   INT            NOT NULL,
    [MedicationId] INT            NOT NULL,
    [Amount]       DECIMAL (5, 2) NOT NULL,
    CONSTRAINT [PK_tePrescriptions] PRIMARY KEY CLUSTERED ([Id] ASC)
);



