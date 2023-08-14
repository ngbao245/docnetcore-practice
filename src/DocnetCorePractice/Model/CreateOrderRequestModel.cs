namespace DocnetCorePractice.Model
{
    public class CreateOrderRequestModel
    {
        public string UserId { get; set; }
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        public string CaffeId { get; set; }
        public int Volumn { get; set; }
    }
}
