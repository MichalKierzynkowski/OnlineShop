using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories

{
    public class ProductRepository : IProductRepository
    {
        private readonly OnlineShopDbContext _context;
        public ProductRepository(OnlineShopDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }
        public IQueryable<Product> GetAll()
        {
             return _context.Products;
        }

        public Product GetById(Guid id)
        {
           return _context.Products.SingleOrDefault(p => p.Id == id);
        }

        public Product Add(Product product)
        {
           _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

      
        public void Update(Product product)
        {
            _context.Products.Update(product);
        }
        public void Delete(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}