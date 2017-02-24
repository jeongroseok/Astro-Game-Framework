using System.Collections.Generic;

namespace Astro.Features.Crafting
{
    public interface ICrafter
    {
        IEnumerable<TResult> Craft(IRecipe recipe);
    }
}
