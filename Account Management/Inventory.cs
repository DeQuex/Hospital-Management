namespace Account_Management
{
    public class Inventory
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

        public new string GetType() => type;

        public string GetId() => id;

        public string GetName() => name;

        public int GetAmount() => amount;
        private string GetDescription() => description;
    }
}
