using Iterator.Interfaces;
using Iterator.Iterators;
using Iterator.Models;

namespace Iterator.Aggregates
{
    public class PokeApiCollection : IAggregate<Pokemon>
    {
        public IIterator<Pokemon> CreateIterator()
        {
            return new PokeApiIterator();
        }
    }
}
