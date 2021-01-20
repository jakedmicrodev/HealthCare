CREATE TABLE [dbo].[teClaimsArchive] (
    [ClaimID]              INT            NOT NULL,
    [PatientID]            INT            NULL,
    [ProviderID]           INT            NULL,
    [ServiceID]            INT            NULL,
    [ExpenseDate]          DATETIME       NULL,
    [ExpenseAmount]        DECIMAL (6, 2) NULL,
    [ExpenseTypeID]        INT            NULL,
    [ClaimNumber]          NVARCHAR (20)  NULL,
    [InsuranceClaimNumber] NVARCHAR (25)  NULL,
    [PaidCD]               SMALLINT       NULL,
    [MedicationID]         SMALLINT       NULL,
    [MedicationAmount]     DECIMAL (5, 2) NULL,
    [PayeeID]              INT            NULL
);

