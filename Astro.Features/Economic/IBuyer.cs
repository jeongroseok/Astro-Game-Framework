using Astro.Services;

namespace Astro.Features.Economic
{
    public interface IBuyer<TTransaction> where TTransaction : ITransaction
    {
        void Approve(TTransaction transaction);
    }
}
