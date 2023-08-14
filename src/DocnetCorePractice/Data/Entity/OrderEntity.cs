using DocnetCorePractice.Enum;

namespace DocnetCorePractice.Data.Entity
{
    public class OrderEntity : Entity
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public double TotalPrice { get; set; }
        public StatusOrder Status { get; set; }
    }
}
