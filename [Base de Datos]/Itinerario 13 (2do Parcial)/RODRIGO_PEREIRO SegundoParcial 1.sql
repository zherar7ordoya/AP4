Use SegundoParcial
CREATE TABLE autor (
id_autor INT NOT NULL PRIMARY KEY,
nombre_autor VARCHAR NOT NULL
);
CREATE TABLE editorial (
id_editorial INT NOT NULL PRIMARY KEY,
nombre_editorial VARCHAR NOT NULL
);
CREATE TABLE categoria (
id_categoria INT NOT NULL PRIMARY KEY,
nombre_categoria VARCHAR NOT NULL
);
CREATE TABLE lector (
id_lector INT NOT NULL PRIMARY KEY,
nombre_lector VARCHAR NOT NULL
);
CREATE TABLE libro (
id_libro INT NOT NULL PRIMARY KEY,
nombre_libro VARCHAR NOT NULL,
id_autor INT FOREIGN KEY REFERENCES autor(id_autor),
id_editorial INT  FOREIGN KEY REFERENCES editorial(id_editorial),
id_categoria INT  FOREIGN KEY REFERENCES categoria(id_categoria)
);
CREATE TABLE prestamo (
id_libro INT NOT NULL FOREIGN KEY REFERENCES libro(id_libro),
id_lector INT NOT NULL FOREIGN KEY REFERENCES lector(id_lector),
fecha_devolucion DATETIME NOT NULL 
)