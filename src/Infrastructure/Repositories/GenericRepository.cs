using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Infrastructure.Repositories;

public class GenericRepository<TKey, TEntity> : IRepository<TKey, TEntity> where TEntity : class, IEntity<TKey> where TKey : struct
{
    private readonly OnlineShopDbContext _context;

    public GenericRepository(OnlineShopDbContext context)
    {
        _context = context;
    }
    
    public IQueryable<TEntity> Get()
    {
        var dbSet = GetDbSet();
        return dbSet.AsQueryable();
    }

    public TEntity Get(TKey key)
    {
        var dbSet = GetDbSet();
        return dbSet.FirstOrDefault(x => x.Id.Equals(key));
    }

    public TEntity Add(TEntity entity)
    {
        var dbSet = GetDbSet();
        EntityEntry<TEntity> result = dbSet.Add(entity);
        _context.SaveChanges();
        return result.Entity;
    }

    public TEntity Update(TEntity entity)
    {
        var dbSet = GetDbSet();
        EntityEntry<TEntity> result = dbSet.Update(entity);
        _context.SaveChanges();
        return result.Entity;
    }

    private DbSet<TEntity> GetDbSet()
    {
        var dbSet = _context.Set<TEntity>();
        _context.Database.EnsureCreated();
        return dbSet;
    }
}