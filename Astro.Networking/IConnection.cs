using System;

namespace Astro.Networking
{
    public interface IConnection : IDisposable
    {
        bool Connected { get; }

        int Send(byte[] buffer, int offset, int size);
        int Receive(byte[] buffer, int offset, int size);
    }
}
