using Microsoft.EntityFrameworkCore;
using WeatherBA.Shared.Entities;

namespace WeatherBA.Data;
public class BaseRepo<T> : IAsyncRepo<T> where T : class
{
    private readonly WeatherContext _context;

    public BaseRepo(WeatherContext context)
    {
        _context = context;
    }
    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }
    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }
    public Task<T> AddAsync(T entity)
    {
        throw new NotImplementedException();
    }
    public Task DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }
    public Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
