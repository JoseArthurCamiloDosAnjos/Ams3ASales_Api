namespace AMS3ASales.api.Domain
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Description { get; set; }        
        public double Stock { get; set; }
        public double Price {  get; set; }
        public string? ImageUrl { get; set; }
        public string? IsActive {  get; set; }
        public bool IsAvailable { get; set; }
        public DateTime CreatedData { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }

    }
}
