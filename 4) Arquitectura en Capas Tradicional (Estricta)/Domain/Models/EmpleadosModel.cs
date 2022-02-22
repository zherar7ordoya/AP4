using DataAccess.Contracts;
using DataAccess.Entities;
using DataAccess.Repositories;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace Domain.Models
{
    public class EmpleadosModel : IDisposable
    {
        //Campos
        private int id;
        private string legajo;
        private string nombre;
        private string email;
        private DateTime nacimiento;
        private int edad;

        //Ver nota en constructor.
        private readonly IEmpleadosRepository repositorio;

        //El valor del estado puede ser asignado desde fuera de la clase, pero
        //solo puede ser obtenido desde dentro de la clase (private get). Eso
        //es encapsulamiento. Todo mecanismo de protección es encapsulamiento.
        public EntityState Estado { private get ; set; }

        private List<EmpleadosModel> lista;

        #region PROPIEDADES------------------------------------------------------------

        /**
         *   PROPIEDADES DE LOS CAMPOS
         * Modelo de Vista: Validaciones
         * -----------------------------
         * ¿En qué capa se coloca la validación de datos?
         * ¿Cómo se hacen las validaciones?
         * 
         * Tanto en desarrollo web como escritorio, las validaciones se hacen
         * en la capa presentación porque tiene eventos y controles que hacen
         * de esta tarea más fácil y didáctica.
         * 
         * Con el patrón MVC, podemos usar la Anotaciones de Datos.
         * La capa de dominio también puede validar los datos.
         * En la capa de dominio se hace la validación de las reglas
         * comerciales. En una aplicación web (por seguridad) se realiza tanto
         * en la capa presentación como en la de dominio (es decir, tanto al
         * lado del cliente como al lado del servidor) ya que los datos pueden
         * ser alterados usando javascript u otro medio.
         * En web, se puede tener la validación solo en la capa presentación
         * pero no se puede tenerla solo en la capa de negocio ya que para
         * validar un dato, el dato tendría que viajar hasta el servidor y
         * volver desde allí el válido o no, y eso tomaría tiempo.
         * En desktop, se puede tener la validación tanto en la capa de
         * presentación como de dominio. Esto depende:
         * 
         * Si los modelos de vista y los modelos de dominio son completamente
         * iguales, se puede realizar la validación en el modelo de dominio.
         * 
         * Si los modelos de vista y los modelos de dominio son totalmente
         * diferentes, se puede realizar la validación en el modelo de vista.
         * 
         * En este caso (el presente) como ambos modelos son iguales, se usarán
         * las (siguientes) propiedades (pragmático) para hacer validaciones.
         * 
         * Se podrían usar los setters para efectuar las validaciones. Pero lo
         * más sencillo y con más funcionalidades es usar la librería de
         * anotaciones (Data Annotations, propio del framework MVC).
         */
        public int Id { get => id; set => id = value; }

        [Required(ErrorMessage = "Legajo es obligatorio")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Legajo debe ser numérico")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Legajo = 10 dígitos")]
        public string Legajo { get => legajo; set => legajo = value; }

        [Required]
        [RegularExpression("^[A-Z]+[a-zA-Z]+$", ErrorMessage = "Nombre solo letras")]
        [StringLength(maximumLength: 100, MinimumLength = 3)]
        public string Nombre { get => nombre; set => nombre = value; }

        [Required]
        [EmailAddress]
        public string Email { get => email; set => email = value; }

        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }
        public int Age { get => edad; private set => edad = value; }

        #endregion

        //CONSTRUCTOR
        //Se inicializa la interfaz del repositorio, que será:
        //          intefaz repositorio = objeto repositorio
        //Es decir, declaramos el repositorio no mediante su clase concreta,
        //sino la declaramos desde su interfaz, donde están declarados los
        //métodos. De esa manera, tenemos bajo acoplamiento y se mantiene
        //encapsulada la clase concreta. Además, esto ayuda a realizar las
        //pruebas unitarias.
        public EmpleadosModel()
        {
            repositorio = new EmpleadosRepository();
        }


        public string Guardar()
        {
            string mensaje = null;

            try
            {
                var empleado = new Empleados();

                empleado.Id = id;
                empleado.Legajo = legajo;
                empleado.Nombre = nombre;
                empleado.Email = email;
                empleado.Nacimiento = nacimiento;

                switch (Estado)
                {
                    case EntityState.Agregado:
                        // Ejecutar reglas comerciales / cálculos.
                        repositorio.Agregar(empleado);
                        mensaje = "Agregado correctamente.";
                        break;

                    case EntityState.Eliminado:
                        // Ejecutar reglas comerciales / cálculos.
                        repositorio.Eliminar(id);
                        mensaje = "Eliminado correctamente.";
                        break;

                    case EntityState.Modificado:
                        // Ejecutar reglas comerciales / cálculos.
                        repositorio.Modificar(empleado);
                        mensaje = "Modificado correctamente.";
                        break;
                }
            }
            catch (Exception ex)
            {
                SqlException sex = ex as SqlException;

                //SQL Server 2627: registro ya existe (duplicado)
                if (sex != null && sex.Number == 2627)
                {
                    mensaje = "No se admiten duplicados.";
                }
                else
                {
                    mensaje = ex.ToString();
                }
            }
            return mensaje;
        }


        public List<EmpleadosModel> Seleccionar()
        {
            var empleados = repositorio.Seleccionar();

            lista = new List<EmpleadosModel>();

            foreach (Empleados item in empleados)
            {
                var nacimiento = item.Nacimiento;

                lista.Add(new EmpleadosModel
                {
                    id = item.Id,
                    legajo = item.Legajo,
                    nombre = item.Nombre,
                    email = item.Email,
                    nacimiento = item.Nacimiento,
                    edad = CalcularEdad(nacimiento)
                });
            }
            return lista;
        }


        private int CalcularEdad(DateTime fecha)
        {
            DateTime ahora = DateTime.Now;
            return ahora.Year - fecha.Year;
        }

        //---

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        //---

        public IEnumerable<EmpleadosModel> EncontrarLegajo(string filtro)
        {
            return lista.FindAll(e =>
            e.Legajo.Contains(filtro) || e.Nombre.Contains(filtro)
            );
        }

    }
}
