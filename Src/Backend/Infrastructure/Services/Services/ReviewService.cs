using Application.Interfaces.Persistance;
using Application.Interfaces.Services;
using EmployeeReview.Domain.Models.Entities;

namespace Infrastructure.Services.Services;

public class ReviewService : GenericService<Review>, IReviewService
{
    public ReviewService(IAppDbContext dbContext) : base(dbContext)
    {
    }
}