USE DB_Pruebas_C08380
GO

-- CREATE TABLES
BEGIN

	DROP TABLE IF EXISTS dbo.Persona;

	CREATE TABLE dbo.Persona
	(
		IdPersona INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		Nombre NVARCHAR(100) NOT NULL,
		Email NVARCHAR(50) NOT NULL,
		AceptacionDeTerminos BIT NOT NULL,
		AceptacionDePoliticaDePrivacidad BIT NOT NULL,
		Activa BIT NOT NULL,
	)

END

SELECT * FROM dbo.[Persona]