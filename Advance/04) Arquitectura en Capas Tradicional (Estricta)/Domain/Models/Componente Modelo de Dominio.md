# Componente Modelos

En un Modelo de Dominio, los atributos y los comportamientos están juntos para mantener el purismo de la Programación Orientada a Objetos (POO).

Sin embargo, usualmente la mayoría está acostumbrado a construir esta arquitectura en capas clásicas + el antipatrón "Modelo Anémico".

El Modelo de Dominio Anémico no es más que entidades representadas por clases que solo contienen datos y conexiones a otras entidades. Estas clases carecen de lógica de negocio alguna. Y generalmente se colocan en servicios, utilidades, ayudantes, etc.

El modelo de dominio anémico es simplemente un diseño de estilo de procedimientos. Los objetos de entidad anémicos no son objetos reales, ya que carecen de comportamiento (métodos). Solo contienen propiedades de datos y, por tanto, no se trata de un diseño orientado a objetos.

