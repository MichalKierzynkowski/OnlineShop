using Domain.Entities;

namespace Domain.Interfaces;

public interface IRepository<TKey, TEntity> where TEntity : IEntity<TKey> where TKey : struct
{
    IQueryable<TEntity> Get();
    TEntity Get(TKey key);
    TEntity Add(TEntity entity);
    TEntity Update(TEntity entity);
}