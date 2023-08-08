using DocnetCorePractice.Enum;

namespace DocnetCorePractice.Data.Entity
{
    public class UserEntity : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public double Balance { get; set; }
        public int TotalProduct { get; set; }
        public Roles Roles { get; set; }
    }
}
