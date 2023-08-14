namespace DocnetCorePractice.Data.Entity
{
    public class OrderItemEntity : Entity
    {
        public string UserId { get; set; }
        public string CaffeId { get; set; }
        public string OrderId { get; set; }
        public string CaffeName { get; set; }
        public int Volumn { get; set; }// số lượng
        public double UnitPrice { get; set; }
        public double ItemPrice { get; set; }
        public bool IsActice { get; set; }
        public bool IsDeleted { get; set; }
    }
}
