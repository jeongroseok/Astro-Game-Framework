namespace Astro.Features.Inventory
{
    public interface IItemDescriptor
    {
        int MaxStackAmount { get; }
        int StackAmount { get; }
    }
}
