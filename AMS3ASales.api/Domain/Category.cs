namespace AMS3ASales.api.Domain
{
    public class Category
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Desription { get; set; }
        public bool IsActive { get; set; }
        public string? ImageUrl { get; set; }
        public ICollection<Product> products { get; set; }
    }
}
