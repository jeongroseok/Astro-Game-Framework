using Astro.Services;
using System.Collections.Generic;

namespace Astro.Features.Economic.Shops
{
    public interface IShop<TProductDescriptor, TTransaction> : ISeller<TTransaction>
        where TProductDescriptor : IProductDescriptor
        where TTransaction : ITransaction
    {
        IEnumerable<TProductDescriptor> Products { get; }
        TProductDescriptor this[int index] { get; }
    }
}
