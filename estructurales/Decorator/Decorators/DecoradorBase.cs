using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Decorators
{
    public abstract class DecoradorBase : IGeneradorMensaje
    {
        protected IGeneradorMensaje _componente;

        public DecoradorBase(IGeneradorMensaje componente)
        {
            _componente = componente;
        }

        public virtual string ObtenerMensaje()
        {
            return _componente.ObtenerMensaje();
        }
    }
}
