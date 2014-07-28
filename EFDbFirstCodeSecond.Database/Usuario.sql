CREATE TABLE [dbo].[Usuario]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [email] VARCHAR(50) NOT NULL, 
    [password] VARCHAR(50) NOT NULL, 
    [nombre] VARCHAR(MAX) NOT NULL
)
