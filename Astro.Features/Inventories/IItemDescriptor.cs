namespace Astro.Features.Inventories
{
    public interface IItemDescriptor
    {
        int MaxStackAmount { get; }
        int StackAmount { get; }
    }
}
