using WeatherBA.Shared.Common;

namespace WeatherBA.Data;
public interface IAsyncRepo<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
    void UpdateAsync(T entity);
    void Remove(T entity);
    Task<bool> SaveChangesAsync();
}