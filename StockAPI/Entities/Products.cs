namespace StockAPI.Entities
{
    public class Products
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Ean { get; set; } = string.Empty;
        public bool IsActive { get; set; } = false;
        public int StockQuantity { get; set; }
        public DateOnly Validate { get; set; }
        public DateOnly CreatedAt { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}
