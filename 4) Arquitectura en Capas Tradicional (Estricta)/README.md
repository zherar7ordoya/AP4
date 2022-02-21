# NOTA:

�stas son las 3 capas principales de aplicaci�n. Hay una cuarta capa de soporte que tambi�n estar� siempre presente, sobre todo en las aplicaciones web: es la **capa corte transversal**, tambi�n conocido como la capa com�n o capa de soporte.

## Capa Com�n, de Soporte, o de Corte Transversal

Esta capa es com�n para todas las capas, es decir tanto Presentaci�n, Dominio, y Acceso a Datos, pueden acceder a ella.

La **responsabilidad** de esta capa es la gesti�n de seguridad y operaciones (como autenticaci�n, autorizaci�n, almacenamiento en cach�, comunicaci�n, gesti�n de configuraci�n, gesti�n de excepciones, administraci�n del estado y validaciones de seguridad).

En las �ltimas d�cadas se hizo muy popular usar la capa com�n solo para la **persistencia de datos de la entidad empresarial** (conocida como CAPA ENTIDAD). Me parece una buena estrategia, yo la he usado muchas veces: se obtiene mayor flexibilidad y la cantidad de c�digo y clases disminuyen considerablemente puesto que solo se necesita declarar los atributos de la entidad una vez y cualquier capa puede reutilizar las clases definidas, pero estamos violando los principios de la arquitectura en capas y la programaci�n orientada objetos, m�s aun si se tiene mucha l�gica de negocio (porque, de esta manera, ya no se tiene bajo acoplamiento).

**Las entidades pertenecen a la capa de negocio**, no se pueden exponer. De otro modo, a futuro, se tendr� una escalabilidad limitada y un mantenimiento dif�cil.

Sin embargo, no tiene nada de malo, se puede hacer de esta manera **siempre y cuando** se tenga **muy poca l�gica de negocio** y est� pensado para **aplicaciones peque�as**.
