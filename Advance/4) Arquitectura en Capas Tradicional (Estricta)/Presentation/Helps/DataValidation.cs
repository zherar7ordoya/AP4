using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Presentation.Helps
{
    internal class DataValidation
    {
        private readonly ValidationContext contexto;
        private readonly List<ValidationResult> resultados;
        private readonly bool valido;
        private string mensaje;

        public DataValidation(object instancia)
        {
            contexto = new ValidationContext(instancia);
            resultados = new List<ValidationResult>();
            valido = Validator.TryValidateObject(instancia, contexto, resultados, true);
        }

        public bool Validar()
        {
            if(valido is false)
            {
                foreach(ValidationResult item in resultados)
                {
                    mensaje += item.ErrorMessage + "\n";
                }
                MessageBox.Show(mensaje);
            }
            return valido;
        }
    }
}
