using Domain.Entities;
using Domain.Factories;

namespace Application.Factories
{
  public class ProductFactory : IProductFactory
  {
    public Product Create(ProductDetail details, Category category, string name)
    {
            Product product = new Product(name,details,category);
            
            return product;

    }
  }
}