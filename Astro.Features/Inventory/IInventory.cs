using System;
using System.Collections.Generic;

namespace Astro.Features.Inventory
{
	/// <summary>
	/// 아이템 쌓기 기능으로 인해 Inventory, Slot, Item 구조를 선택하지 않았다.
	/// Slot + Slot으로 쌓게되면 Slot객체가 Stack기능을 담당하게 되는대 이 경우
	/// 아이템별로 최대 스택 값을 설정 할 방법이 없다.
	/// 따라서 Inventoriable 객체가 최대 스택값과 현재 스택값 그리고
	/// 실제 아이템의 참조를 가지게 되는 구조가 되었다.
	/// Inventory Table
	/// --------------------------------
	/// | InventoryId | ItemId | Count |
	/// --------------------------------
	/// </summary>
	public interface IInventory<T> : IList<T>
		where T : class, IItemDescriptor
	{
		event EventHandler<InventoryEventArgs<T>> Added;
		event EventHandler<InventoryEventArgs<T>> Removed;
	}
}