USE RJCodeAdvance

go

CREATE TABLE Empleados
  (
     IdPK        INT IDENTITY(1, 1) PRIMARY KEY,
     IdLegajo    VARCHAR (10) UNIQUE NOT NULL,
     Nombre      NVARCHAR(80) NOT NULL,
     Email       NVARCHAR(150) NOT NULL,
     Nacimiento  DATE NOT NULL
  )

INSERT INTO Empleados
VALUES      ('6587542361',
             'Juan Gabriel',
             'juan@gmail.com',
             '2007-03-11')

INSERT INTO Empleados
VALUES      ('6587542362',
             'Gonzalo',
             'gonzalo@gmail.com',
             '1983-06-17')

INSERT INTO Empleados
VALUES      ('6587542363',
             'Marta',
             'marta@gmail.com',
             '1986-11-19')

INSERT INTO Empleados
VALUES      ('6587542364',
             'Lisandro',
             'lisandro@gmail.com',
             '2008-05-25')

INSERT INTO Empleados
VALUES      ('6587542365',
             'Anna Maria',
             'anna@gmail.com',
             '1983-01-07')

SELECT *
FROM   Empleados 


