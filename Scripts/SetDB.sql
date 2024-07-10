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
Comentario VARCHAR(MAX) NOT NULL,
IdEstablecimiento INT REFERENCES dbo.Establecimientos(IdEstablecimiento)
)
GO
CREATE TABLE dbo.Calificaciones
(
IdCalificacion INT PRIMARY KEY IDENTITY(1,1),
IdUsuario INT REFERENCES dbo.Usuarios(IdUsuario),
IdEstablecimiento INT REFERENCES dbo.Establecimientos(IdEstablecimiento),
Fecha DATETIME NOT NULL DEFAULT(GETDATE()),
Valoracion INT NOT NULL
)