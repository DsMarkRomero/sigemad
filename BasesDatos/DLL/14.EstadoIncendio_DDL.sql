DROP TABLE IF EXISTS dbo.EstadoIncendio;
GO

CREATE TABLE dbo.EstadoIncendio (
	Id int NOT NULL IDENTITY(1,1),
	Descripcion varchar (255) NOT NULL,	
    Obsoleto BIT NOT NULL,
    CONSTRAINT PK_EstadoIncendio PRIMARY KEY (Id)	
);