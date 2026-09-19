using BuilderExample.Modelos;

namespace BuilderExample.Interfaces
{
    public interface IPizzaBuilder
    {
        void Resetear();
        void ConstruirMasa();
        void ConstruirSalsa();
        void ConstruirIngredientes();
        Pizza ObtenerPizza();
    }
}
