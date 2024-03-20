CREATE DATABASE API
GO

USE API
go

CREATE TABLE Persona
(
	id int identity(1,1) primary key,
	nombre varchar(100),
	apellido varchar(100),
	edad int
)
GO

CREATE PROCEDURE sp_verPersonas
AS
BEGIN
	SELECT * FROM Persona
END


EXEC sp_verPersonas

CREATE PROCEDURE sp_InsertarPersonas
	@nombre varchar(100),
	@apellido varchar(100),
	@edad int
AS
BEGIN
	INSERT INTO Persona (nombre,apellido,edad)
	VALUES (@nombre,@apellido,@edad)
END

CREATE PROCEDURE sp_ActualizarPersonas 
	@id int,
	@nombre varchar(100),
	@apellido varchar(100),
	@edad int
AS
BEGIN
	UPDATE Persona set nombre = @nombre, apellido = @apellido,edad = @edad
END

CREATE PROCEDURE sp_EliminarPersonas
	@id int
AS
BEGIN
	DELETE FROM Persona where id = @id
END

CREATE PROCEDURE sp_VerPersonaPorId
	@id int
AS
BEGIN
	SELECT * FROM Persona where id = @id
END