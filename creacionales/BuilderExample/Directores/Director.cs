using BuilderExample.Interfaces;

namespace BuilderExample.Directores
{
    public class Director
    {
        private IPizzaBuilder _builder;

        public Director(IPizzaBuilder builder)
        {
            _builder = builder;
        }

        public void HacerPizzaBasica()
        {
            _builder.ConstruirMasa();
            _builder.ConstruirSalsa();
        }

        public void HacerPizzaCompleta()
        {
            _builder.ConstruirMasa();
            _builder.ConstruirSalsa();
            _builder.ConstruirIngredientes();
        }
    }
}
