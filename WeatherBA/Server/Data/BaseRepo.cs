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
    public async Task<T> AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        return entity;
    }
    public void Remove(T entity)
    {
        _context.Set<T>().Remove(entity);
    }
    public void UpdateAsync(T entity)
    {
        //Nothing
    }
    public async Task<bool> SaveChangesAsync()
    {
       return (await _context.SaveChangesAsync() >= 0);
    }
}
