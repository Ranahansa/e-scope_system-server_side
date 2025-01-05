namespace FlowAPI.Models.Entities
{
    public class Customer
    {
        // Primary Key
        public int Id { get; set; }

        // Customer's Name
        public required string Name { get; set; }

        // Customer's Email
        public required string Email { get; set; }

        // Customer's Phone
        public string? Phone { get; set; }

        // Customer's Status
        public bool Status { get; set; }

        // Customer's Registration Date
        public DateTime RegistrationDate { get; set; }
    }
}
