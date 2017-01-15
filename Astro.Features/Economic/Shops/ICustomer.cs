using Astro.Features.Services;

namespace Astro.Features.Economic.Shops
{
    public interface ICustomer<TTransaction> : IBuyer<TTransaction>
        where TTransaction : ITransaction
    {
    }
}