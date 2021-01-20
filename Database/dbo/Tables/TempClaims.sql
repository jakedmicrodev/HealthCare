CREATE TABLE [dbo].[TempClaims] (
    [Id]                   INT            IDENTITY (1, 1) NOT NULL,
    [ClaimId]              INT            NULL,
    [PatientId]            INT            NULL,
    [ProviderId]           INT            NULL,
    [ServiceId]            INT            NULL,
    [ExpenseDate]          DATETIME       NULL,
    [ExpenseAmount]        MONEY          NULL,
    [ExpenseTypeId]        INT            NULL,
    [ClaimNumber]          VARCHAR (20)   NULL,
    [InsuranceClaimNumber] VARCHAR (25)   NULL,
    [PaidCd]               INT            NULL,
    [MedicationId]         INT            NULL,
    [MedicationAmount]     DECIMAL (5, 2) NULL,
    [PayeeId]              INT            NULL,
    CONSTRAINT [PK_TempClaims] PRIMARY KEY CLUSTERED ([Id] ASC)
);

