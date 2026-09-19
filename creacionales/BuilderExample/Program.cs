using System;
using BuilderExample.Constructores;
using BuilderExample.Directores;

namespace BuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new PizzaMargaritaBuilder();
            var director = new Director(builder);

            Console.WriteLine("--- Preparando Pizza Básica (Solo masa y salsa) ---");
            director.HacerPizzaBasica();
            builder.ObtenerPizza().MostrarPizza();

            Console.WriteLine("\n--- Preparando Pizza Completa (Margarita) ---");
            director.HacerPizzaCompleta();
            builder.ObtenerPizza().MostrarPizza();

            // sin director 
            Console.WriteLine("\n--- Pizza Personalizada por el Cliente ---");
            builder.ConstruirMasa();
            builder.ConstruirSalsa();
            builder.ObtenerPizza().MostrarPizza();
        }
    }
}
