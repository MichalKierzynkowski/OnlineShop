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
        IEnumerable<Product> GetAllCategory();
        Product GetCategoryById(int id);
        Product AddNewCategory(Product newProduct);
        void UpdateCategory(int id, Product product);
        void DeleteCategory(int id);
    }
}
