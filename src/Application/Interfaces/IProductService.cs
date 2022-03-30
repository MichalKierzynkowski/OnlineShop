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
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(Guid id);
        Product AddNewProduct(Product newProduct);
        void UpdateProduct(Guid id, Product product);
        void DeleteProduct(Guid id);
    }
}
