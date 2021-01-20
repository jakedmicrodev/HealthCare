CREATE TABLE [dbo].[teClaims] (
    [Id]          INT          NOT NULL,
    [PatientId]   INT          NOT NULL,
    [ProviderId]  INT          NOT NULL,
    [ClaimNumber] VARCHAR (50) NOT NULL,
    [ClaimId]     INT          NULL,
    CONSTRAINT [PK_teClaims] PRIMARY KEY CLUSTERED ([Id] ASC)
);



