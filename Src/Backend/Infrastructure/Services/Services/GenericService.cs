using Application.Interfaces.Persistance;
using Application.Interfaces.Services;
using EmployeeReview.Domain.Models.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services.Services;

public class GenericService<TEntity> : IGenericService<TEntity>
    where TEntity : BaseEntity
{
    private readonly IAppDbContext _dbContext;

    public GenericService(IAppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        return await _dbContext.Set<TEntity>().FindAsync(id);
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbContext.Set<TEntity>().AsNoTracking().ToListAsync();
    }

    public async Task CreateAsync(TEntity entity)
    {
        await _dbContext.Set<TEntity>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _dbContext.Set<TEntity>().Update(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        _dbContext.Set<TEntity>().Remove(entity);
        await _dbContext.SaveChangesAsync();
    }
}