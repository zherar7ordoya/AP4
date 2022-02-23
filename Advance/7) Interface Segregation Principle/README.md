# Escenario

Aquí tenemos una aplicación de consola que simula la estructura de datos de una aplicación para una biblioteca (es decir, un lugar que presta libros de lectura).

Hay dos proyectos, pero para el siguiente análisis nos enfocaremos en el proyecto de librería de clases de C# (Library).

El proyecto arranca con la interfaz ILibrayItem así:

```
    internal interface ILibraryItem
    {
        string Author { get; set; }
        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckOutDurationInDays { get; set; }
        string LibraryId { get; set; }
        int Pages { get; set; }
        string Title { get; set; }
        void CheckIn();
        void CheckOut();
        DateTime GetDueDate();
    }
```

Así como está, el primer problema es que la interfaz viola el 1er principio SOLID, el Principio de Segregación de Interfaz (ISP).

Segregación significa separar una cosa de otra de la que forma parte para que siga existiendo con independencia.

ISP significa que el cliente no debe ser forzado a depender de interfaces que no usa.

El desarrollo del análisis se puede ver en [este video](https://youtu.be/y1JiMGP51NE).