using WeatherBA.Shared.Common;

namespace WeatherBA.Data;
public interface IAsyncRepo<T> where T : AuditableEntity
{
    // bool SaveChanges();
    Task<T> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}