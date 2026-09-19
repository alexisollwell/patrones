using BuilderExample.Interfaces;
using BuilderExample.Modelos;

namespace BuilderExample.Constructores
{
    public class PizzaMargaritaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public PizzaMargaritaBuilder()
        {
            this.Resetear();
        }

        public void Resetear()
        {
            this._pizza = new Pizza();
        }

        public void ConstruirMasa()
        {
            _pizza.TipoMasa = "Masa fina tradicional";
        }

        public void ConstruirSalsa()
        {
            _pizza.TipoSalsa = "Salsa de tomate casera";
        }

        public void ConstruirIngredientes()
        {
            _pizza.AgregarIngrediente("Queso mozzarella fresco");
            _pizza.AgregarIngrediente("Hojas de albahaca");
        }

        public Pizza ObtenerPizza()
        {
            Pizza resultado = this._pizza;
            this.Resetear();
            return resultado;
        }
    }
}
