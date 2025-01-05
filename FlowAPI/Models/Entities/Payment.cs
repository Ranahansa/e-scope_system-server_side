namespace FlowAPI.Models.Entities
{
    public class Payment
    {
        // Primary Key
        public int Id { get; set; }

        // Payment's Order
        public required Order Order { get; set; }

        // Payment's Amount
        public double Amount { get; set; }

        // Payment's Status
        public bool Status { get; set; }

        // Payment's Registration Date
        public DateTime RegistrationDate { get; set; }
    }
}
