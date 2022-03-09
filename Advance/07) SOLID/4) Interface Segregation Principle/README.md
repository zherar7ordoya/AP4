# Escenario

Aqu� tenemos una aplicaci�n de consola que simula la estructura de datos de una aplicaci�n para una biblioteca (es decir, un lugar que presta libros de lectura).

Hay dos proyectos, pero para el siguiente an�lisis nos enfocaremos en el proyecto de librer�a de clases de C# (Library).

El proyecto arranca con la interfaz ILibrayItem as�:

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

As� como est�, el primer problema es que la interfaz viola el 1er principio SOLID, el Principio de Segregaci�n de Interfaz (ISP).

Segregaci�n significa separar una cosa de otra de la que forma parte para que siga existiendo con independencia.

ISP significa que el cliente no debe ser forzado a depender de interfaces que no usa.

El desarrollo del an�lisis se puede ver en [este video](https://youtu.be/y1JiMGP51NE).