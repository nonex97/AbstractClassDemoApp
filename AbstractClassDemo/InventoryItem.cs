namespace AbstractClassDemo
{
    public abstract class InventoryItem // abstract class is a base class, you build upon it, but it's not a fully formed class. it can't be instantiated
    {
        public string ProductName { get; set; }
        public int QuantityOnHand { get; set; }
    }
}
