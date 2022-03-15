using static System.Console;
using System;
using System.Collections.Generic;

namespace CovariantesContravariantes
{
    internal class Program
    {
        /** PRELIMINARES
         * Los delegados Action y Func toman in y out:
         * -Action: in
         * -Func: out
         */
        static void Main(string[] args)
        {
            // COVARIANZA
            // Asignando clase mayor a clase menor.
            Vehicle v1 = new Car();     //Todos los autos son vehículos...
            Vehicle v2 = new Car();

            Vehicle v3 = new Aircraft();//pero no todos los vehículos son autos.

            Func<Vehicle> func = GetVehicle;
            Vehicle v4 = func();

            // CONTRAVARIANZA
            // Asignando clase menor a clase mayor.
            Action<Car> action = ParkVehicle;
            action(new Car());

            // EN PARÁMETROS DE TIPO GENÉRICO
            ICovariant<Vehicle> covariant1 = (ICovariant<Vehicle>)null;

            // Asignando más a menos (covarianza).
            ICovariant<Vehicle> covariant2 = (ICovariant<Car>)null;

            IContravariant<Vehicle> contravariant1 = (IContravariant<Vehicle>)null;

            // Asignando menos a más (contravarianza).
            IContravariant<Car> contravariant2 = (IContravariant<Vehicle>)null;

            /** POSTLIMINAR
             * Los parámetros Action de entrada son contravariantes.
             * Los parámetros Func de entrada son contravariantes.
             * Los parámetros Func de salida son covariantes.
             * 
             * Para finalizar, un ejemplo del mundo real.
             */
            var sorted = new SortedSet<Car>(new VehicleComparer())
            {
                new Car() { Speed=150 },
                new Car() { Speed=120 },
                new Car() { Speed=170 },

            };
            foreach (var item in sorted) { WriteLine("Speed; {0}", item.Speed); }
            ReadKey();
        }

        static Car GetVehicle() => new Car();
        static void ParkVehicle(Vehicle vehicle) { }
    }

    #region CLASES
    class Vehicle { public int Speed { get; set; } }
    class Car : Vehicle { }
    class Aircraft : Vehicle { }

    class VehicleComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            return x.Speed - y.Speed;
        }
    }
    #endregion

    // OUT significa que estamos generando objetos desde esta interfaz.
    interface ICovariant<out T>
    {
        T Name { get; } // Solo getters.
        T Get();
    }

    // IN significa que estamos recibiendo objetos desde esta interfaz.
    interface IContravariant<in T>
    {
        T Name { set; } // Solo setters.
        void Set(T t);
    }
}
