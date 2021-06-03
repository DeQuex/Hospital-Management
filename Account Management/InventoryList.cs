using System.Collections.Generic;
using System.Linq;

namespace Account_Management
{
    public class InventoryList
    {
        private List<Inventory> list;
        public InventoryList() => list = new List<Inventory>();

        public void Add(Inventory item) => list.Add(item);

        public void Remove(Inventory item) => list.Remove(item);

        public List<Inventory> GetList() => list;

        public List<Inventory> GetByType(string type)
        {
            return list.Where(x => x.getType() == type).ToList();
        }
    }
}
