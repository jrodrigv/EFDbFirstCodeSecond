CREATE TABLE [dbo].[Usuario_Usuario]
(
	[UsuarioId_principal] INT NOT NULL , 
    [UsuarioId_contacto] INT NOT NULL, 
    CONSTRAINT [FK_Usuario_Usuario_ToUsuarioPrincipal] FOREIGN KEY (UsuarioId_principal) REFERENCES Usuario (id), 
    CONSTRAINT [FK_Usuario_Usuario_ToUsuarioContacto] FOREIGN KEY (UsuarioId_contacto) REFERENCES Usuario (id), 
    PRIMARY KEY ([UsuarioId_principal],[UsuarioId_contacto])
)
