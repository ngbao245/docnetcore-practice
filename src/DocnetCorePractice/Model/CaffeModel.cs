using DocnetCorePractice.Enum;

namespace DocnetCorePractice.Model
{
    public class CaffeModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ProductType Type { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
    }
}
