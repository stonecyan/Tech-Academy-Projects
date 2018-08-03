CREATE TABLE [dbo].[Exceptions] (
    [Id]               INT          IDENTITY (1, 1) NOT NULL,
    [ExceptionType]    NVARCHAR(MAX) NULL,
    [ExceptionMessage] NVARCHAR(MAX) NULL,
    [TimeStamp]        DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

