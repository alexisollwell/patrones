using FactoryMethodExample.Interfaces;
using FactoryMethodExample.Modelos;

namespace FactoryMethodExample.Fabricas
{
    public class LogisticaMaritima : Logistica
    {
        public override ITransporte CrearTransporte()
        {
            return new Barco();
        }
    }
}
