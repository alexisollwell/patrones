using System;
using DecoratorPattern.Components;
using DecoratorPattern.Decorators;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {            
            IGeneradorMensaje mensajeBase = new GeneradorChisteApi();
            Console.WriteLine("Base: " + mensajeBase.ObtenerMensaje());
            Console.WriteLine();

            IGeneradorMensaje conPrefijo = new PrefijoDecorator(mensajeBase);
            Console.WriteLine("Con Prefijo: " + conPrefijo.ObtenerMensaje());
            Console.WriteLine();

            IGeneradorMensaje dobleDecorado = new MayusculasDecorator(conPrefijo);
            Console.WriteLine("Doble Decorado: " + dobleDecorado.ObtenerMensaje());
        }
    }
}
