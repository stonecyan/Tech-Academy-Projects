CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NULL, 
    [EmailAddress] VARCHAR(100) NULL, 
    [DOB] DATE NULL, 
    [CarYear] VARCHAR(5) NULL, 
    [CarMake] VARCHAR(50) NULL, 
    [CarModel] VARCHAR(50) NULL, 
    [DUI] VARCHAR(10) NULL, 
    [Ticket] VARCHAR(2) NULL, 
    [Coverage] BIT NULL
)
