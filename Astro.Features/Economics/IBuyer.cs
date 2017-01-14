using Astro.Features.Services;

namespace Astro.Features.Economics
{
    public interface IBuyer<TTransaction> where TTransaction : ITransaction
    {
        void Approve(TTransaction transaction);
    }
}
