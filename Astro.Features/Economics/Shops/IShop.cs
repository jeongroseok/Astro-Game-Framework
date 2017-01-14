using Astro.Features.Services;
using System.Collections.Generic;

namespace Astro.Features.Economics.Shops
{
    public interface IShop<TProductDescriptor, TTransaction> : ISeller<TTransaction>
        where TProductDescriptor : IProductDescriptor
        where TTransaction : ITransaction
    {
        IEnumerable<TProductDescriptor> Products { get; }
        TProductDescriptor this[int index] { get; }
    }
}
