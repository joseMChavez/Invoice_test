

namespace Invoice.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime Expiration { get; set; }
        public float CostUnit { get; set; }
        public float PriceUnit { get; set; }
        public float ItbisPt { get; set; }
        public float PackageCount { get; set; }
        public int Count { get; set; }
        public bool Status { get; set; }
    }
}
