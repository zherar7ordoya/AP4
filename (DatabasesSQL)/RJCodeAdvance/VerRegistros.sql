USE RJCodeAdvance

GO

CREATE PROC VerRegistros @Condicion NVARCHAR(30)
AS
    SELECT *
    FROM   RJCodeAdvance.dbo.Clientes
    WHERE  id LIKE @Condicion + '%'
           OR nombre LIKE @Condicion + '%'

go

EXEC VerRegistros
  'Romeo'