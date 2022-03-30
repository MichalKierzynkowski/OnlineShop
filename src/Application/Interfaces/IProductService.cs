using Application.Dto.Product;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProductService
    {
        IEnumerable<GetProductDto> GetAllProducts();
        GetProductDto GetProductById(Guid id);
        CreateProductDto AddNewProduct(CreateProductDto newProduct);
        void UpdateProduct(Guid id, Product product);
        void DeleteProduct(Guid id);
    }
}
