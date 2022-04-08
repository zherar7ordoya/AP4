using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primera_Interfaz
{
    public class JuntaNombre : INotifyPropertyChanged
    {
        private string nombre, apellido, nombre_completo;

        public string Nombre
        {
            get => nombre;
            set
            {
                nombre = value;
                OnPropertyChanged("Nombre_Completo");
            }
        }
        public string Apellido
        {
            get => apellido;
            set
            {
                apellido = value;
                OnPropertyChanged("Nombre_Completo");
            }
        }
        public string Nombre_Completo
        {
            get => nombre_completo = $"{Nombre} {Apellido}";
            set => nombre_completo = value;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
