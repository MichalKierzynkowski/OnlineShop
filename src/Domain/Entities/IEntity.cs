namespace Domain.Entities;

public interface IEntity<T> where T : struct
{
    public T Id { get; }
}