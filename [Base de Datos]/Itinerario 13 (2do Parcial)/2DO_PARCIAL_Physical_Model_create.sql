-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2022-07-09 04:21:35.426

-- tables
-- Table: Autores
CREATE TABLE Autores (
    cod_autor int  NOT NULL,
    nombre varchar(15)  NOT NULL,
    apellido varchar(15)  NOT NULL,
    CONSTRAINT Autores_pk PRIMARY KEY  (cod_autor)
);

-- Table: Categorias
CREATE TABLE Categorias (
    cod_categoria int  NOT NULL,
    nombre varchar(50)  NOT NULL,
    CONSTRAINT Categorias_pk PRIMARY KEY  (cod_categoria)
);

-- Table: Editoriales
CREATE TABLE Editoriales (
    cod_editorial int  NOT NULL,
    nombre int  NOT NULL,
    CONSTRAINT Editoriales_pk PRIMARY KEY  (cod_editorial)
);

-- Table: Lectores
CREATE TABLE Lectores (
    dni_lector bigint  NOT NULL,
    nombre varchar(15)  NOT NULL,
    apellido varchar(15)  NOT NULL,
    CONSTRAINT Lectores_pk PRIMARY KEY  (dni_lector)
);

-- Table: Libros
CREATE TABLE Libros (
    cod_libro int  NOT NULL,
    titulo varchar(50)  NOT NULL,
    cod_categoria int  NOT NULL,
    cod_autor int  NOT NULL,
    cod_editorial int  NOT NULL,
    CONSTRAINT Libros_ak_1 UNIQUE (cod_categoria),
    CONSTRAINT Libros_ak_2 UNIQUE (cod_autor),
    CONSTRAINT Libros_ak_3 UNIQUE (cod_editorial),
    CONSTRAINT Libros_pk PRIMARY KEY  (cod_libro)
);

-- Table: Libros_Devoluciones
CREATE TABLE Libros_Devoluciones (
    cod_libro int  NOT NULL,
    fecha_devolucion date  NOT NULL,
    dni_lector bigint  NOT NULL,
    CONSTRAINT Libros_Devoluciones_pk PRIMARY KEY  (cod_libro,fecha_devolucion)
);

-- foreign keys
-- Reference: Autores_Libros (table: Autores)
ALTER TABLE Autores ADD CONSTRAINT Autores_Libros
    FOREIGN KEY (cod_autor)
    REFERENCES Libros (cod_autor);

-- Reference: Categorias_Libros (table: Categorias)
ALTER TABLE Categorias ADD CONSTRAINT Categorias_Libros
    FOREIGN KEY (cod_categoria)
    REFERENCES Libros (cod_categoria);

-- Reference: Editoriales_Libros (table: Editoriales)
ALTER TABLE Editoriales ADD CONSTRAINT Editoriales_Libros
    FOREIGN KEY (cod_editorial)
    REFERENCES Libros (cod_editorial);

-- Reference: Libros_Devoluciones_Lectores (table: Libros_Devoluciones)
ALTER TABLE Libros_Devoluciones ADD CONSTRAINT Libros_Devoluciones_Lectores
    FOREIGN KEY (dni_lector)
    REFERENCES Lectores (dni_lector);

-- Reference: Libros_Devoluciones_Libros (table: Libros_Devoluciones)
ALTER TABLE Libros_Devoluciones ADD CONSTRAINT Libros_Devoluciones_Libros
    FOREIGN KEY (cod_libro)
    REFERENCES Libros (cod_libro);

-- sequences
-- Sequence: Autores_seq
CREATE SEQUENCE Autores_seq
    START WITH 1 
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    NO CYCLE
    NO CACHE;

-- Sequence: Categorias_seq
CREATE SEQUENCE Categorias_seq
    START WITH 1 
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    NO CYCLE
    NO CACHE;

-- Sequence: Editoriales_seq
CREATE SEQUENCE Editoriales_seq
    START WITH 1 
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    NO CYCLE
    NO CACHE;

-- Sequence: Lectores_seq
CREATE SEQUENCE Lectores_seq
    START WITH 1 
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    NO CYCLE
    NO CACHE;

-- Sequence: Libros_seq
CREATE SEQUENCE Libros_seq
    START WITH 1 
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    NO CYCLE
    NO CACHE;

-- End of file.

