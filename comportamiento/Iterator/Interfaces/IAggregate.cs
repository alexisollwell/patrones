using Iterator.Interfaces;

namespace Iterator.Interfaces
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
