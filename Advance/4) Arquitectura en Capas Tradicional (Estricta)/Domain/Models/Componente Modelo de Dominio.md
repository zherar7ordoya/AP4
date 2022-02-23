# Componente Modelos

En un Modelo de Dominio, los atributos y los comportamientos est�n juntos para mantener el purismo de la Programaci�n Orientada a Objetos (POO).

Sin embargo, usualmente la mayor�a est� acostumbrado a construir esta arquitectura en capas cl�sicas + el antipatr�n "Modelo An�mico".

El Modelo de Dominio An�mico no es m�s que entidades representadas por clases que solo contienen datos y conexiones a otras entidades. Estas clases carecen de l�gica de negocio alguna. Y generalmente se colocan en servicios, utilidades, ayudantes, etc.

El modelo de dominio an�mico es simplemente un dise�o de estilo de procedimientos. Los objetos de entidad an�micos no son objetos reales, ya que carecen de comportamiento (m�todos). Solo contienen propiedades de datos y, por tanto, no se trata de un dise�o orientado a objetos.

