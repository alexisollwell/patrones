using System;
using System.Collections.Generic;
using AdapterClima.Interfaces;

namespace AdapterClima.Models
{
    public class ClimaAntiguoMock : IClimaAntiguo
    {
        private readonly List<Cities> _ciudades;

        public ClimaAntiguoMock()
        {
            _ciudades = new List<Cities>
            {
                new Cities { name = "Mexico", temperature = 22.5 },
                new Cities { name = "Madrid", temperature = 15.0 },
                new Cities { name = "Bogota", temperature = 18.2 }
            };
        }

        public double ObtenerTemperatura(string ciudad)
        {
            Console.WriteLine($"Consultando el clima local estático para: {ciudad}");
            var ciudadEncontrada = _ciudades.Find(c => c.name.Equals(ciudad, StringComparison.OrdinalIgnoreCase));
            if (ciudadEncontrada != null)
            {
                return ciudadEncontrada.temperature;
            }
            throw new ArgumentException($"La ciudad '{ciudad}' no está soportada.");
        }
    }
}
