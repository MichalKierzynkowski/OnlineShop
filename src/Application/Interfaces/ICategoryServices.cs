using Application.Dto.Category;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICategoryServices
    {
        IEnumerable<GetCategoryDto> GetAllCategories();
        GetCategoryDto GetCategoryById(Guid id);
        Guid AddNewCategory(CreateCategoryDto newCategory);
        void UpdateCategory(Guid id, Category category);
        void DeleteCategory(Guid id);
    }
}
