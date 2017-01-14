using System;

namespace Astro.Features.Services
{
    public interface ITransaction : IDisposable
    {
        void Commit();
        void Rollback();
    }
}
