using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly OnlineShopDbContext _context;
        public CategoryRepository(OnlineShopDbContext context)
        {
            _context = context;
        }
        public IQueryable<Category> GetAll()
        {
           return _context.Categories;
        }

        public Category GetById(Guid id)
        {
            return _context.Categories.SingleOrDefault(p => p.Id == id);
        }
        public Category Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public void Delete(Category category)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
