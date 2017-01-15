using System;
using System.Net;

namespace Astro.Networking
{
    public interface IAcceptor : IDisposable
    {
        bool Running { get; }

        void Bind(EndPoint endPoint);
        void Run(int backlog);
        IConnection Accept();
    }
}
