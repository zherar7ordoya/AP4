using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FieldValidatorAPI
{
    #region DEFINICIÓN DE DELEGADOS
    public delegate bool DelegadoValidaCampoRequerido(string campo);
    public delegate bool DelegadoValidaLargoDeCadena(string campo, int minimo, int maximo);
    public delegate bool DelegadoValidaFecha(string campo, out DateTime fecha);
    public delegate bool DelegadoValidaPatron(string campo, string patron);
    public delegate bool DelegadoValidaComparacion(string campo1, string campo2);
    #endregion

    public class CommonFieldValidatorFunctions
    {
        #region VARIABLES DE MIEMBRO PARA CADA DELEGADO
        private static DelegadoValidaCampoRequerido dvCampoRequerido = null;
        private static DelegadoValidaLargoDeCadena dvLargoDeCadena = null;
        private static DelegadoValidaFecha dvFecha = null;
        private static DelegadoValidaPatron dvPatron = null;
        private static DelegadoValidaComparacion dvComparacion = null;
        #endregion

        #region PROPIEDADES PARA CADA DELEGADO RELACIONADO
        /// <summary>
        /// Entonces, para exponer nuestros objetos delegados al código de
        /// llamada, creemos una propiedad pública estática de solo lectura
        /// para cada delegado relacionado.
        /// Con cada una de estas propiedades públicas, estamos creando un
        /// nuevo objeto delegado del tipo de delegado apropiado y pasando el
        /// nombre de método apropiado al constructor de tipos de delegado.
        /// 
        /// Usamos un Patrón de Diseño SINGLETON para garantizar que solo se
        /// pueda crear una instancia de cada uno de estos objetos delegados.
        /// 
        /// </summary>
        public static DelegadoValidaCampoRequerido DvCampoRequerido
        {
            get
            {
                if (dvCampoRequerido == null) dvCampoRequerido = new DelegadoValidaCampoRequerido(CampoRequeridoValido);
                return dvCampoRequerido;
            }
        }

        public static DelegadoValidaLargoDeCadena DvLargoDeCadena {
            get
            {
                if (dvLargoDeCadena == null) dvLargoDeCadena = new DelegadoValidaLargoDeCadena(LargoDeCadenaValido);
                return dvLargoDeCadena;
            }
        }

        public static DelegadoValidaFecha DvFecha {
            get
            {
                if (dvFecha == null) dvFecha = new DelegadoValidaFecha(FechaValida);
                return dvFecha;
            }
        }

        public static DelegadoValidaPatron DvPatron {
            get
            {
                if (dvPatron == null) dvPatron = new DelegadoValidaPatron(PatronValido);
                return dvPatron;
            }
        }

        public static DelegadoValidaComparacion DvComparacion {
            get
            {
                if (dvComparacion == null) dvComparacion = new DelegadoValidaComparacion(ComparacionValida);
                return dvComparacion;
            }
        }
        #endregion

        #region IMPLEMENTACIONES DE MÉTODO PARA CADA DELEGADO
        private static bool CampoRequeridoValido(string fieldVal)
        {
            if (!string.IsNullOrEmpty(fieldVal)) return true;
            return false;
        }

        private static bool LargoDeCadenaValido(string fieldVal, int min, int max)
        {
            if (fieldVal.Length >= min && fieldVal.Length <= max) return true;
            return false;
        }

        private static bool FechaValida(string dateTime, out DateTime validDateTime)
        {
            if (DateTime.TryParse(dateTime, out validDateTime)) return true;
            return false;
        }

        private static bool PatronValido(string fieldVal, string regularExpressionPattern)
        {
            Regex regex = new Regex(regularExpressionPattern);

            if (regex.IsMatch(fieldVal)) return true;
            return false;
        }

        private static bool ComparacionValida(string field1, string field2)
        {
            if (field1.Equals(field2)) return true;
            return false;
        }
        #endregion
    }
}
