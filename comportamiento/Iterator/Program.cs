using System;
using System.Threading.Tasks;
using Iterator.Aggregates;

namespace Iterator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var pokeCollection = new PokeApiCollection();
            var iterator = pokeCollection.CreateIterator();

            int counter = 0;
            int limit = 25;

            Console.WriteLine($"Vamos a iterar sobre los primeros {limit} Pokémon.\n");

            while (await iterator.HasNextAsync())
            {
                var pokemon = iterator.Next();
                counter++;
                Console.WriteLine($"{counter}. {pokemon.GetPokemonInfo()}");

                if (counter >= limit)
                {
                    break;
                }
            }

            Console.WriteLine("\nIteración completada.");
        }
    }
}
