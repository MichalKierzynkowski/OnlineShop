namespace Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ProductDetail ProductDetail { get; set; }
        public Category Category { get; set; }

        protected Product()
        {
        }

        public Product(string name, ProductDetail productDetail, Category category)
        {
            Name = name;
            Id = Guid.NewGuid();
            ProductDetail = productDetail;
            Category = category;
        }
    }
}