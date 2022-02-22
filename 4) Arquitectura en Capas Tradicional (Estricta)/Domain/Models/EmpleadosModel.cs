using DataAccess.Entities;
using DataAccess.Repositories;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace Domain.Models
{
    internal class EmpleadosModel
    {
        private int id;
        private string legajo;
        private string nombre;
        private string email;
        private DateTime nacimiento;
        private int edad;

        private readonly EmpleadosRepository repositorio;
        public EntityState Estado { private get; set; }
        private List<EmpleadosModel> lista;

        //Propiedades / Modelo de Vista / Validar Datos
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

        public IEnumerable<EmpleadosModel> EncontrarLegajo(string filtro)
        {
            return lista.FindAll(e =>
            e.Legajo.Contains(filtro) || e.Nombre.Contains(filtro)
            );
        }

        private int CalcularEdad(DateTime fecha)
        {
            DateTime ahora = DateTime.Now;
            return ahora.Year - fecha.Year;
        }
    }
}
