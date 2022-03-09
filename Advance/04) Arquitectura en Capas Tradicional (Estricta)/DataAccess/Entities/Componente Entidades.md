# Componente Entidades

Son los objetos de persistencia.

Tendremos una clase por cada tabla. Lo que se hace es un mapeo de tablas relacionales a objetos relacionales. 

Si se usa Entity Framework, el nombre de la clase debe tener el mismo nombre de la tabla, solo que en plural ya que EF, por defecto, solo reconoce nombres de clases en plural (sin embargo, se puede configurar para que trabaje en singular).