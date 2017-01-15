using System;

namespace Astro.Features.Inventory
{
    public class InventoryEventArgs<T> : EventArgs
    {
        public InventoryEventArgs(T item)
        {
            this.Item = item;
        }

        public T Item { get; private set; }
    }
}