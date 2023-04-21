using EmployeeReview.Domain.Models.Common;

namespace Application.Interfaces.Services;

public interface IGenericService<TEntity>
    where TEntity : BaseEntity
{
    Task<TEntity> GetByIdAsync(int id);
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task CreateAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(int id);
}
