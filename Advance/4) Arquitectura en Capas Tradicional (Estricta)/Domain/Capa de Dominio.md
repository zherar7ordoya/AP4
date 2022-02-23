# Capa de negocio o dominio

Es el componente más importante,  es el corazón de la aplicación. **Codifica las reglas comerciales y el flujo de trabajo del mundo real** que determinan como se pueden crear, almacenar y cambiar los datos de un objeto comercial.

**Las reglas comerciales** describen las **operaciones y restricciones** que se aplica a una organización.

**El flujo de trabajo** consta de las tareas, los pasos de procedimiento, la información de entrada y salida requerida y las herramientas necesarias para cada paso de ese procedimiento.

Si resulta que la capa de dominio es muy compleja, es decir tiene un montón de métodos con  lógica de negocio, podemos agregar la **capa de servicio o aplicación**, que es una capa delgada que sirve como fachada y envuelve la capa de dominio y que se encarga del flujo de operaciones (coordina todas las transacciones).

Opcionalmente, en esta capa se pueden usar patrones tales como:

- Entidad de dominio, modelo de dominio u objeto de negocio
- Objeto de valor
- Ruta agregada.
- Script de transacción
- Tabla modular
- El objeto de transferencia de datos
- Delegado de negocios
- Unidad de trabajo
- Etc...

## Componentes

Modelos de Dominio, Objetos de Valor, y Servicios de Dominio, son patrones de diseño.