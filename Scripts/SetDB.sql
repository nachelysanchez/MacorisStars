CREATE DATABASE MacorisStarsDb
GO
USE MacorisStarsDb
GO

CREATE TABLE dbo.Usuarios
(
IdUsuario INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(50) NOT NULL,
NombreUsuario VARCHAR(40) NOT NULL,
Contrasena VARCHAR(80) NOT NULL,
)
GO
CREATE TABLE dbo.Categorias
(
IdCategoria INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(50) NOT NULL
)
GO
CREATE TABLE dbo.Establecimientos
(
IdEstablecimiento INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(60) NOT NULL,
Descripcion VARCHAR(MAX) NOT NULL,
Imagen VARBINARY(MAX),
IdCategoria INT REFERENCES dbo.Categorias(IdCategoria)
)
GO
CREATE TABLE dbo.Resenas
(
IdResena INT PRIMARY KEY IDENTITY(1,1),
IdUsuario INT REFERENCES dbo.Usuarios(IdUsuario),
Fecha DATETIME NOT NULL DEFAULT(GETDATE()),
Comentario VARCHAR(MAX) NOT NULL
)
GO
CREATE TABLE dbo.Calificaciones
(
IdCalificacion INT PRIMARY KEY IDENTITY(1,1),
IdUsuario INT REFERENCES dbo.Usuarios(IdUsuario),
Fecha DATETIME NOT NULL DEFAULT(GETDATE()),
Valoracion INT NOT NULL
)
GO
CREATE TABLE EstablecimientosResenaDetalle
(
Id INT PRIMARY KEY IDENTITY(1,1),
IdEstablecimiento INT FOREIGN KEY REFERENCES Establecimientos(IdEstablecimiento),
IdResena INT FOREIGN KEY REFERENCES Resenas(IdResena)
)
GO
CREATE TABLE EstablecimientosCalificacionDetalle
(
Id INT PRIMARY KEY IDENTITY(1,1),
IdEstablecimiento INT FOREIGN KEY REFERENCES Establecimientos(IdEstablecimiento),
IdCalificacion INT FOREIGN KEY REFERENCES Calificaciones(IdCalificacion)
)
