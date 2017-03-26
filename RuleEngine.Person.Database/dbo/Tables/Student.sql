CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL, 
    [FirstName] NCHAR(50) NOT NULL, 
    [LastName] NCHAR(50) NULL,
	CONSTRAINT [PK_Student] PRIMARY KEY ([Id])
)
