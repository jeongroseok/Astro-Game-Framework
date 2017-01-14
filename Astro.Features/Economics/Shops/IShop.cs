using Astro.Features.Services;
using System.Collections.Generic;

namespace Astro.Features.Economics.Shops
{
    public interface IShop<TProductDescriptor, TTransaction> : ISeller<TTransaction>, IEnumerable<TProductDescriptor>
        where TProductDescriptor : IProductDescriptor
        where TTransaction : ITransaction
    {
        TProductDescriptor this[int index] { get; }
    }
}
