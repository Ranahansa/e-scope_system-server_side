namespace FlowAPI.Models.Entities
{
    public class InventoryItem
    {
        // Primary Key
        public int Id { get; set; }

        // Inventory Item's Product
        public required Product Product { get; set; }

        // Inventory Item's Quantity
        public int Quantity { get; set; }

        // Inventory Item's Status
        public bool Status { get; set; }

        // Inventory Item's Registration Date
        public DateTime RegistrationDate { get; set; }
    }
}
