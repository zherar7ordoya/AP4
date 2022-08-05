namespace Core
{
    public class Presentador
    {
		private readonly ICalculadoraVista VISTA;
		private decimal MEMORIA_INTERMEDIA = 0;
		private char OPERACION_EN_CURSO = ' ';
		private bool OPERACION_COMPLETADA = false;

		public Presentador(ICalculadoraVista vista)
		{
			VISTA = vista;
		}

		public void BotonNumeroPresionado(string valor)
		{
			if (VISTA.Pantalla == "0." || OPERACION_COMPLETADA)
			{
				VISTA.Pantalla = valor;
				OPERACION_COMPLETADA = false;
			}
			else
			{
				VISTA.Pantalla += valor;
			}
		}

		public void BotonOperadorPresionado(string operador)
		{

			if (OPERACION_EN_CURSO == ' ')
			{
				OPERACION_EN_CURSO = operador.Contains("+") ? '+' : operador[0];
				MEMORIA_INTERMEDIA = decimal.Parse(VISTA.Pantalla);
				VISTA.Pantalla = "0.";
			}
			else
			{
				decimal valorActual = decimal.Parse(VISTA.Pantalla);

                switch (OPERACION_EN_CURSO)
                {
					case '+':
						MEMORIA_INTERMEDIA += valorActual;
						break;
					case '-':
						MEMORIA_INTERMEDIA -= valorActual;
						break;
					case 'x':
						MEMORIA_INTERMEDIA *= valorActual;
						break;
					case '/':
						MEMORIA_INTERMEDIA /= valorActual;
						break;
					default:
						MEMORIA_INTERMEDIA = 0m;
						break;
                }

                VISTA.Pantalla = MEMORIA_INTERMEDIA.ToString();
				OPERACION_COMPLETADA = true;
			}

		}

		public void BotonLimpiezaPresionado()
		{
			VISTA.Pantalla = "0.";
			MEMORIA_INTERMEDIA = 0;
			OPERACION_EN_CURSO = ' ';
			OPERACION_COMPLETADA = false;
		}
	}
}
