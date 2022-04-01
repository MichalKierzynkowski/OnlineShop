using Application.Dto.Category;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CategoryServices:ICategoryServices
    {
        public CategoryServices()
        {

        }

        public Guid AddNewCategory(CreateCategoryDto newCategory)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GetCategoryDto> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public GetCategoryDto GetCategoryById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Guid id, Category category)
        {
            throw new NotImplementedException();
        }
    }
}
