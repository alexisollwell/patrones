using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Decorators
{
    public class MayusculasDecorator : DecoradorBase
    {
        public MayusculasDecorator(IGeneradorMensaje componente) : base(componente) { }

        public override string ObtenerMensaje()
        {
            var mensaje = base.ObtenerMensaje();
            return mensaje.ToUpper();
        }
    }
}
