using System.Threading.Tasks;

namespace Iterator.Interfaces
{
    public interface IIterator<T>
    {
        Task<bool> HasNextAsync();
        T Next();
    }
}
