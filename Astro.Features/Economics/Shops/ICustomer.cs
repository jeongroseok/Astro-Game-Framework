using Astro.Features.Services;

namespace Astro.Features.Economics.Shops
{
    public interface ICustomer<TTransaction> : IBuyer<TTransaction>
        where TTransaction : ITransaction
    {
    }
}