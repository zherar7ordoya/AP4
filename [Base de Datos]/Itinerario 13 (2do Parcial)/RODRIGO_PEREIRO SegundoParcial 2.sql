Use SegundoParcial
CREATE TABLE autor (
id_autor INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
nombre_autor VARCHAR(500) NOT NULL
);
CREATE TABLE editorial (
id_editorial INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
nombre_editorial VARCHAR(500) NOT NULL
);
CREATE TABLE categoria (
id_categoria INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
nombre_categoria VARCHAR(500) NOT NULL
);
CREATE TABLE lector (
id_lector INT NOT NULL PRIMARY KEY,
nombre_lector VARCHAR(500) NOT NULL
);
CREATE TABLE libro (
id_libro INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
nombre_libro VARCHAR(500) NOT NULL,
id_autor INT FOREIGN KEY REFERENCES autor(id_autor),
id_editorial INT  FOREIGN KEY REFERENCES editorial(id_editorial),
id_categoria INT  FOREIGN KEY REFERENCES categoria(id_categoria)
);
CREATE TABLE prestamo (
id_libro INT NOT NULL FOREIGN KEY REFERENCES libro(id_libro),
id_lector INT NOT NULL FOREIGN KEY REFERENCES lector(id_lector),
fecha_devolucion DATETIME NOT NULL 
);
insert into autor
VALUES
('Issac Asimov'),
('Ray Bradbury'),
('H. G. Wells'),
('Julio Verne'),
('Arthur C. Clarke'),
('George Orwell'),
('Jorge Luis Borges'),
('Gabriel García Márquez'),
('William Shakespeare'),
('Franz Kafka'),
('Miguel de Cervantes'),
('Edgar Allan Poe'),
('Vladimir Nabokov'),
('Charles Dickens'),
('Julio Cortázar');
insert into editorial
VALUES
('Editorial Mirahadas'),
('Errara Natura'),
('Pre-textos'),
('Sexto Piso'),
('Nórdica'),
('Acantilado'),
('De Conatus'),
('Cabaret Voltaire'),
('La Huerta Grande'),
('Impedimenta'),
('La Umbría y la Solana'),
('Blackie Books'),
('Caro Raggio'),
('Libros del Asteroide'),
('Renacimiento'),
('Pálido Fuego'),
('Páginas de Espuma'),
('Menoscuarto'),
('Periférica'),
('Visor');
insert into lector
VALUES
('27989789','Julio Baccaro'),
('13649035','Julieta Bal'),
('32624047','Silvia Balán'),
('25838122','Ángeles Balbiani'),
('35701830','Marita Ballesteros'),
('28272041','Walter Balzarini'),
('42077386','Aldo Barbero'),
('22444333','Carmen Barbieri'),
('15710012','Juan Carlos Barbieri'),
('30513531','Emilio Bardi'),
('39355942','Mario Baroffio'),
('41526784','Gastón Barral'),
('37010105','Paola Barrientos'),
('20820067','Julio César Barton'),
('44060243','Domingo Basile');
insert into categoria
VALUES
('Ciencia Ficcion'),
('Romanticos'),
('Terror'),
('Cocina'),
('Geografia'),
('Ficción'),
('Juveniles'),
('Poeticos'),
('Recreativos'),
('Monografías'),
('Renacimiento'),
('Libros de gran formato'),
('Biografías'),
('De viaje'),
('Literatura y lingüísticos'),
('Científicos');


insert into libro
VALUES
('Robots e Imperio','1','12','1'),
('Fundacion','1','12','1'),
('Don Quijote de la Mancha','11','15','15'),
('Poemas EAP','12','11','8'),
('Rayuela','15','16','15'),
('La moneda de hierro','7','20','8'),
('La metamorfosis','10','3','9'),
('Cuento de Navidad','14','9','6'),
('Historia de dos ciudades','14','9','15'),
('Oliver Twist','14','9','15'),
('La invención de Valts','13','8','9'),
('Lolita','13','8','15'),
('Romeo y Julieta','9','15','11'),
('Hamlet','9','15','11'),
('El maravilloso traje de color vainilla','2','7','9'),
('Crónicas marcianas','2','7','1');






