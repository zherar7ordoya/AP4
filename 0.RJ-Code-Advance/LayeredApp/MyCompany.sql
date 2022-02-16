CREATE DATABASE MyCompany

go

USE MyCompany

go

CREATE TABLE Employee
  (
     IdPK     INT IDENTITY(1, 1) PRIMARY KEY,
     IdNumber VARCHAR (10) UNIQUE NOT NULL,
     Name     NVARCHAR(80) NOT NULL,
     Mail     NVARCHAR(150) NOT NULL,
     Birthday DATE NOT NULL
  )

INSERT INTO Employee
VALUES      ('6587542361',
             'Juan Gabriel',
             'Juan@gmail.com',
             '20000524')

INSERT INTO Employee
VALUES      ('6587542362',
             'Gonazalo',
             'Gonazalo@gmail.com',
             '20000524')

INSERT INTO Employee
VALUES      ('6587542363',
             'Marta',
             'Marta@gmail.com',
             '20000524')

INSERT INTO Employee
VALUES      ('6587542364',
             'Lisandro',
             'Lisandro@gmail.com',
             '20000524')

INSERT INTO Employee
VALUES      ('6587542365',
             'Anna Maria',
             'Anna@gmail.com',
             '20000524')

SELECT *
FROM   Employee 


