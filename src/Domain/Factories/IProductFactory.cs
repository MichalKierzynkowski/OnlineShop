using Domain.Entities;

namespace Domain.Factories
{
    public interface IProductFactory
    {
        Product Create(ProductDetail details, Category category, string name);
    }
}