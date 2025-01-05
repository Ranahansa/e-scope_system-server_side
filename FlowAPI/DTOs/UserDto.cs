namespace FlowAPI.DTOs
{
    public class UserDto
    {
        // User's Name
        public required string Name { get; set; }

        // User's Email
        public required string Email { get; set; }

        // User's Phone
        public string? Phone { get; set; }

        // User's Status
        public bool Status { get; set; }

        // User's Registration Date
        public DateTime RegistrationDate { get; set; }
    }
}
