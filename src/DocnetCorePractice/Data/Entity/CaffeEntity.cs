using DocnetCorePractice.Enum;

namespace DocnetCorePractice.Data.Entity
{
    public class CaffeEntity : Entity
    {
        public string Name { get; set; }
        public ProductType Type { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public bool IsActive { get; set; }
    }
}
