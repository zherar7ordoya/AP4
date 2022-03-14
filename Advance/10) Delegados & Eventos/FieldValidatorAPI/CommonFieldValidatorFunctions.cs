using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FieldValidatorAPI
{
    #region DEFINICIÓN DE DELEGADOS
    public delegate bool RequiredValidDel(string fieldVal);
    public delegate bool StringLengthValidDel(string fieldVal, int min, int max);
    public delegate bool DateValidDel(string fieldVal, out DateTime validDateTime);
    public delegate bool PatternMatchDel(string fieldVal, string pattern);
    public delegate bool CompareFieldsValidDel(string fieldVal, string fieldValCompare);
    #endregion

    public class CommonFieldValidatorFunctions
    {
        #region VARIABLES DE MIEMBRO PARA CADA DELEGADO
        private static RequiredValidDel requiredValidDel = null;
        private static StringLengthValidDel stringLengthValidDel = null;
        private static DateValidDel dateValidDel = null;
        private static PatternMatchDel patternMatchDel = null;
        private static CompareFieldsValidDel compareFieldsValidDel = null;
        #endregion

        #region PROPIEDADES PARA CADA DELEGADO RELACIONADO
        /// <summary>
        /// Entonces, para exponer nuestros objetos delegados al código de
        /// llamada, creemos una propiedad pública estática de solo lectura
        /// para cada delegado relacionado.
        /// Con cada una de estas propiedades públicas, estamos creando un
        /// nuevo objeto delegado del tipo de delegado apropiado y pasando el
        /// nombre de método apropiado al constructor de tipos de delegado.
        /// Usamos un patrón singleton para garantizar que solo se pueda crear
        /// una instancia de cada uno de estos objetos delegados.
        /// </summary>
        public static RequiredValidDel RequiredFieldValidDel
        {
            get
            {
                if (requiredValidDel == null) requiredValidDel = new RequiredValidDel(RequiredFieldValid);
                return requiredValidDel;
            }
        }
        // ...descifrar... (uf!) 18:44


        #endregion

        #region IMPLEMENTACIONES DE MÉTODO PARA CADA DELEGADO
        private static bool RequiredFieldValid(string fieldVal)
        {
            if (!string.IsNullOrEmpty(fieldVal)) return true;
            return false;
        }

        private static bool StringFieldLengthValid(string fieldVal, int min, int max)
        {
            if (fieldVal.Length >= min && fieldVal.Length <= max) return true;
            return false;
        }

        private static bool DateFieldValid(string dateTime, out DateTime validDateTime)
        {
            if (DateTime.TryParse(dateTime, out validDateTime)) return true;
            return false;
        }

        private static bool FieldPatternValid(string fieldVal, string regularExpressionPattern)
        {
            Regex regex = new Regex(regularExpressionPattern);

            if (regex.IsMatch(fieldVal)) return true;
            return false;
        }

        private static bool FieldComparisonValid(string field1, string field2)
        {
            if (field1.Equals(field2)) return true;
            return false;
        }
        #endregion
    }
}
