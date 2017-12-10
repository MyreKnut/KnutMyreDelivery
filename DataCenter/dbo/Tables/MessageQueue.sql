CREATE TABLE [dbo].[MessageQueue] (
    [KUNDENR_ANONYMISERT] NVARCHAR (50)  NULL,
    [VALID_FROM_DTTM]     DATETIME       NULL,
    [KUNDE_POSTNR]        NVARCHAR (50)  NULL,
    [KUNDE_POSTSTED]      NVARCHAR (100) NULL,
    [KUNDEANSVARLIG_ID]   NVARCHAR (50)  NULL,
    [BANK_ID]             NVARCHAR (50)  NULL,
    [SAMTYKKE_FORSIKRING] CHAR (1)       NULL,
    [SAMTYKKE_BANK]       CHAR (1)       NULL,
    [ID]                  INT            IDENTITY (1, 1) NOT NULL
);

