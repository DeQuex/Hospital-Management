using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Management
{
    class InventoryList
    {
        private List<Inventory> list;
        public InventoryList() => list = new List<Inventory>();

        public void Add(Inventory item) => list.Add(item);

        public void Remove(Inventory item) => list.Remove(item);

        public List<Inventory> GetList() => list;
    }
}
