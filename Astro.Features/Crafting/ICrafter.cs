using System.Collections.Generic;

namespace Astro.Features.Crafting
{
    public interface ICrafter
    {
        IEnumerable<ICraftingResult> Craft(ICraftingMethod method);
    }
}
