namespace Application.Core.Repositories.Interfaces;

public interface IRepositoryBase<T>
{
    Task<T> CreateItemAsync(T item);
    Task<T> GetItemAsync(Guid id);
    Task<T> UpdateItemAsync(T item);
}