using ABS;
using BEL;
using BLL;

namespace MVPExample
{
    public static class Factory
    {
        public static ICalculadoraBLL CreateCalcPresenter()
        {
            return new CalculadoraPresenter(CreateCalcForm(), CreateCalcModel());
        }

        public static ICalculadoraUIL CreateCalcForm()
        {
            return new CalculadoraForm();
        }

        public static ICalculadoraBEL CreateCalcModel()
        {
            return new CalculadoraModel();
        }
    }
}
