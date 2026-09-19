using System;
using System.Collections.Generic;

namespace BuilderExample.Modelos
{
    public class Pizza
    {
        private List<string> _ingredientes = new List<string>();
        public string TipoMasa { get; set; }
        public string TipoSalsa { get; set; }

        public void AgregarIngrediente(string ingrediente)
        {
            _ingredientes.Add(ingrediente);
        }

        public void MostrarPizza()
        {
            Console.WriteLine($"Masa: {TipoMasa} | Salsa: {TipoSalsa}");
            Console.WriteLine("Ingredientes: " + string.Join(", ", _ingredientes));
        }
    }
}
