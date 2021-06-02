using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Management
{
    class Inventory
    {
        private string type;
        private string id;
        private string name;
        private int amount;
        private string description;

        public Inventory(string type, string id, string name, int amount, string description)
        {
            this.type = type;
            this.id = id;
            this.name = name;
            this.amount = amount;
            this.description = description;
        }

        public string getType() => type;

        public string getId() => id;

        public string getName() => name;

        public int getAmount() => amount;
        private string getDescription() => description;
    }
}
