using EmployeeReview.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces.Persistance;

public interface IAppDbContext
{
    DbSet<Employee> Employees { get; set; }
    DbSet<ReviewQuestion> ReviewQuestions { get; set; }
    DbSet<QuestionAnswer> QuestionAnswers { get; set; }
    DbSet<Review> Reviews { get; set; }
    DbSet<TEntity> Set<TEntity>() where TEntity : class;
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
}
