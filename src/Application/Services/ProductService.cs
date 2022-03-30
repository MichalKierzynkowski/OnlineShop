using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;

        }
        public Product AddNewCategory(Product newProduct)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllCategory()
        {
            throw new NotImplementedException();
        }

        public Product GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
