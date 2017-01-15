using System;

namespace Astro.Services
{
    public interface ITransaction : IDisposable
    {
        void Commit();
        void Rollback();
    }
}
