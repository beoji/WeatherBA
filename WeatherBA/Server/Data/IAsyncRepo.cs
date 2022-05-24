using WeatherBA.Shared.Common;

namespace WeatherBA.Data;
public interface IAsyncRepo<T> where T : class
{
    // bool SaveChanges();
    Task<T> GetByIdAsync(int id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
    void UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}