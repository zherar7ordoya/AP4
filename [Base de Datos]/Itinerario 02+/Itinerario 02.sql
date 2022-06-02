CREATE TABLE CATEGORIAS
(
  cod_cat INT NOT NULL,
  nombre VARCHAR(25) NOT NULL,
  PRIMARY KEY (cod_cat)
);

CREATE TABLE DEPORTES
(
  cod_deporte INT NOT NULL,
  nombre VARCHAR(25) NOT NULL,
  arancel INT NOT NULL,
  PRIMARY KEY (cod_deporte)
);

CREATE TABLE SOCIOS
(
  cod_socio INT NOT NULL,
  apellido VARCHAR(25) NOT NULL,
  nombre VARCHAR(25) NOT NULL,
  cod_cat INT NOT NULL,
  PRIMARY KEY (cod_socio),
  FOREIGN KEY (cod_cat) REFERENCES CATEGORIAS(cod_cat)
);

CREATE TABLE PROFESORES
(
  cod_profesor INT NOT NULL,
  nombre VARCHAR(25) NOT NULL,
  apellido VARCHAR(25) NOT NULL,
  cod_deporte INT NOT NULL,
  PRIMARY KEY (cod_profesor),
  FOREIGN KEY (cod_deporte) REFERENCES DEPORTES(cod_deporte)
);

CREATE TABLE CUOTAS
(
  num_cuota INT NOT NULL,
  valor_cuota INT NOT NULL,
  fecha DATE NOT NULL,
  cod_socio INT NOT NULL,
  PRIMARY KEY (num_cuota, cod_socio),
  FOREIGN KEY (cod_socio) REFERENCES SOCIOS(cod_socio)
);

CREATE TABLE PRACTICAS
(
  día INT NOT NULL,
  hora INT NOT NULL,
  cod_socio INT NOT NULL,
  cod_deporte INT NOT NULL,
  PRIMARY KEY (cod_socio, cod_deporte),
  FOREIGN KEY (cod_socio) REFERENCES SOCIOS(cod_socio),
  FOREIGN KEY (cod_deporte) REFERENCES DEPORTES(cod_deporte)
);