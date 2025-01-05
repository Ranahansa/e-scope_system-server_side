namespace FlowAPI.Models.Entities
{
    public class Supplier
    {
        // Primary Key
        public int Id { get; set; } // Changed 'nt' to 'int'

        // Supplier's Name
        public string? Name { get; set; } // Made 'Name' nullable

        // Supplier's Email
        public string? Email { get; set; } // Made 'Email' nullable

        // Supplier's Phone
        public string? Phone { get; set; } // Made 'Phone' nullable

        // Supplier's Address
        public string? Address { get; set; } // Made 'Address' nullable

        // Supplier's Status
        public bool Status { get; set; }

        // Supplier's Registration Date
        public DateTime RegistrationDate { get; set; }
    }
}
