
USE master
GO

-- Crear la base de datos
CREATE DATABASE CalculadoraDB;
GO

-- Usar la base de datos recién creada
USE CalculadoraDB;
GO

-- Crear la tabla para guardar operaciones
CREATE TABLE Operaciones (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Numero1 FLOAT,
    Operador NVARCHAR(10),
    Numero2 FLOAT NULL,
    Resultado NVARCHAR(50),
    Fecha DATETIME DEFAULT GETDATE()
);
GO

SELECT * FROM Operaciones
