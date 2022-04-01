using Application.Dto.Category;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Interfaces;

namespace Application.Services
{
    public class CategoryServices:ICategoryServices
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;
        public CategoryServices(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<GetCategoryDto> GetAllCategories()
        {
            var categories = _repository.GetAll();
            return _mapper.Map<IEnumerable<GetCategoryDto>>(categories);
        }

        public GetCategoryDto GetCategoryById(Guid id)
        {
            var category = _repository.GetById(id);
            return _mapper.Map<GetCategoryDto>(category);
        }
        public Guid AddNewCategory(CreateCategoryDto newCategory)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Guid id)
        {
            throw new NotImplementedException();
        }

        

        public void UpdateCategory(Guid id, Category category)
        {
            throw new NotImplementedException();
        }
    }
}
