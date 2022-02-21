# NOTA:

Éstas son las 3 capas principales de aplicación. Hay una cuarta capa de soporte que también estará siempre presente, sobre todo en las aplicaciones web: es la **capa corte transversal**, también conocido como la capa común o capa de soporte.

## Capa Común, de Soporte, o de Corte Transversal

Esta capa es común para todas las capas, es decir tanto Presentación, Dominio, y Acceso a Datos, pueden acceder a ella.

La **responsabilidad** de esta capa es la gestión de seguridad y operaciones (como autenticación, autorización, almacenamiento en caché, comunicación, gestión de configuración, gestión de excepciones, administración del estado y validaciones de seguridad).

En las últimas décadas se hizo muy popular usar la capa común solo para la **persistencia de datos de la entidad empresarial** (conocida como CAPA ENTIDAD). Me parece una buena estrategia, yo la he usado muchas veces: se obtiene mayor flexibilidad y la cantidad de código y clases disminuyen considerablemente puesto que solo se necesita declarar los atributos de la entidad una vez y cualquier capa puede reutilizar las clases definidas, pero estamos violando los principios de la arquitectura en capas y la programación orientada objetos, más aun si se tiene mucha lógica de negocio (porque, de esta manera, ya no se tiene bajo acoplamiento).

**Las entidades pertenecen a la capa de negocio**, no se pueden exponer. De otro modo, a futuro, se tendrá una escalabilidad limitada y un mantenimiento difícil.

Sin embargo, no tiene nada de malo, se puede hacer de esta manera **siempre y cuando** se tenga **muy poca lógica de negocio** y esté pensado para **aplicaciones pequeñas**.
