CREATE DATABASE HistorialesMedicos

go

USE HistorialesMedicos

go

CREATE TABLE Usuarios
  (
     idUsuario  INT PRIMARY KEY IDENTITY,
     Nombre     VARCHAR(50),
     Usuario    NVARCHAR(30),
     Contrasena NVARCHAR(40)
  ) 

go

CREATE TABLE Pacientes
  (
     idPaciente      INT PRIMARY KEY IDENTITY,
     Nombres         VARCHAR(40) NOT NULL,
     Apellidos       VARCHAR(60) NOT NULL,
     FechaNacimiento DATE NOT NULL,
     TipoSangre      NVARCHAR(10) NOT NULL,
     Correo          NVARCHAR(40) NULL,
     Telefono        VARCHAR(15) NOT NULL,
     Estado          BIT DEFAULT(1)
  )

go

CREATE TABLE Alergias
  (
     idAlergia   INT PRIMARY KEY IDENTITY,
     idPaciente  INT FOREIGN KEY REFERENCES Pacientes(idPaciente),
     Nombre      NVARCHAR(40) NOT NULL,
     Descripcion VARCHAR(60) NULL
  ) 

go

CREATE TABLE EnfermedadesCronicas
  (
     idEnfermedad     INT PRIMARY KEY IDENTITY,
     idPaciente       INT FOREIGN KEY REFERENCES Pacientes(idPaciente),
     Nombre           VARCHAR(60) NOT NULL,
     Descripcion      VARCHAR(100) NULL,
     FechaDiagnostico DATE NULL
  ) 

go

CREATE TABLE IMC
  (
     idIMC      INT PRIMARY KEY IDENTITY,
	 idPaciente INT FOREIGN KEY REFERENCES Pacientes(idPaciente),
     Peso       FLOAT NOT NULL,
     Estatura   FLOAT NOT NULL,
	 Fecha		DATE NOT NULL
  ) 

go

CREATE TABLE HistoriasMedicas
  (
     idHistoria      INT PRIMARY KEY IDENTITY,
     idPaciente      INT FOREIGN KEY REFERENCES Pacientes(idPaciente),
     /* Consulta, Emergencia, Revisión, Seguimiento, etc. */
     Motivo          VARCHAR(50) NOT NULL,
     Fecha           DATE NOT NULL,
     Sintomas        VARCHAR(256) NULL,
     Diagnostico     VARCHAR(256) NULL,
     Tratamiento     VARCHAR(256) NULL,
     Detalles        VARCHAR(256) NULL,
     PresionArterial NVARCHAR(20) NULL,
     Temperatura     FLOAT NULL
  ) 

go

CREATE TABLE Estudios
  (
     idEstudio  INT PRIMARY KEY IDENTITY,
     idHistoria INT FOREIGN KEY REFERENCES HistoriasMedicas(idHistoria),
     Nombre     VARCHAR(40) NOT NULL,
     Documento  VARBINARY(max) NOT NULL,
     Detalles   VARCHAR(256) NULL
  ) 

go