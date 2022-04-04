namespace Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public Guid  CategoryId { get; set; }
        public Guid ProductDetailId { get; set; }
        public string Name { get; set; }
     

        public Product()
        {
        }

        public Product(string name, Guid productDetailId,Guid categoryId,Guid id)
        {
            Name = name;
            Id = id;
            ProductDetailId = productDetailId;
            CategoryId = categoryId;
        }
    }
}