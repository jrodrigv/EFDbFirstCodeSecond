CREATE TABLE [dbo].[Libro]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [titulo] VARCHAR(MAX) NOT NULL, 
    [estado] VARCHAR(50) NOT NULL, 
    [progreso] INT NOT NULL, 
    [UsuarioId] INT NOT NULL, 
    CONSTRAINT [FK_Libro_ToUsuario] FOREIGN KEY ([UsuarioId]) REFERENCES [Usuario](Id)
)
