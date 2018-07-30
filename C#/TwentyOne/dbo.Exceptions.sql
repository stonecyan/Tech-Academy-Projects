CREATE TABLE [dbo].[Exceptions] (
    [Id]               INT          IDENTITY (1, 1) NOT NULL,
    [ExceptionType]    VARCHAR (50) NULL,
    [ExceptionMessage] VARCHAR (MAX) NULL,
    [TimeStamp]        DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

