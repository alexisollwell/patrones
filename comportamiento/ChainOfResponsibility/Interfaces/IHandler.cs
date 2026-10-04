using System.Threading.Tasks;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Interfaces
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        Task<IpRequestData> HandleAsync(IpRequestData request);
    }
}
