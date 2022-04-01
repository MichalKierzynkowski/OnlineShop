using Application.Dto.Product;
using Domain.Entities;

namespace Application.Interfaces
{
  public interface IProductService
    {
        IEnumerable<GetProductDto> GetAllProducts();
        GetProductDto GetProductById(Guid id);
        Guid AddNewProduct(CreateProductDto newProduct);
        void UpdateProduct(Guid id, Product product);
        void DeleteProduct(Guid id);
    }
}
