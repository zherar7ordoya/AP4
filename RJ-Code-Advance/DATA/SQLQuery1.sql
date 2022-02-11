--B�squeda de datos exactos
SELECT * FROM Clientes WHERE Nombre='romeo'

--B�squeda de datos por aproximaci�n
SELECT * FROM Clientes WHERE ID LIKE '12%'
GO

--Procedimiento
CREATE PROC VerRegistros
@Condicion nvarchar(30)
AS
SELECT * FROM Clientes WHERE ID LIKE @Condicion + '%' OR Nombre LIKE @Condicion + '%' 
GO
EXEC VerRegistros 'Ta'
