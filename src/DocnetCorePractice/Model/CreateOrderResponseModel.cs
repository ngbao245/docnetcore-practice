namespace DocnetCorePractice.Model
{
    public class CreateOrderResponse
    {
        public string UserId { get; set; }
        public string OrderId { get; set; }
        public double Total { get; set; }
        public List<ResponseItem> Items { get; set; }
    }

    public class ResponseItem
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int Volumn { get; set; }
        public int DisCount { get; set; }
        public double Price { get; set; }

    }
}
