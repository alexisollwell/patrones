using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Decorators
{
    public class PrefijoDecorator : DecoradorBase
    {
        public PrefijoDecorator(IGeneradorMensaje componente) : base(componente) { }

        public override string ObtenerMensaje()
        {
            var mensaje = base.ObtenerMensaje();
            return $"[CHISTE] {mensaje}";
        }
    }
}
