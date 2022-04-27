namespace Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public Guid ProductDetailId { get; set; }
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
      
       

        public Product()
        {
        }

        public Product(string name, Guid productDetailId, Guid categoryId)
        {
            Name = name;
            Id = Guid.NewGuid();
            ProductDetailId = productDetailId;
            CategoryId = categoryId;
            
        }
    }
}