using FactoryMethodExample.Interfaces;
using FactoryMethodExample.Modelos;

namespace FactoryMethodExample.Fabricas
{
    public class LogisticaTerrestre : Logistica
    {
        public override ITransporte CrearTransporte()
        {
            return new Camion();
        }
    }
}
