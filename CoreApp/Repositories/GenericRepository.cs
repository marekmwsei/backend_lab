namespace CoreApp.Repositories;

public interface IGenericRepository
{
    Task<T?> AddAsync(T entity);
    Task<T?> FindByIdAsync(int id);
    Task<IEnumerable<T>> FindAllAsync();
    Task DeleteByIdAsync (int id);
    
}