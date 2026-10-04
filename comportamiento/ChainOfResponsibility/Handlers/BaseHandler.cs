using System.Threading.Tasks;
using ChainOfResponsibility.Interfaces;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers
{
    public abstract class BaseHandler : IHandler
    {
        private IHandler? _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual async Task<IpRequestData> HandleAsync(IpRequestData request)
        {
            if (_nextHandler != null)
            {
                return await _nextHandler.HandleAsync(request);
            }

            return request;
        }
    }
}
