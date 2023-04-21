using Application.Interfaces.Persistance;
using Application.Interfaces.Services;
using EmployeeReview.Domain.Models.Entities;

namespace Infrastructure.Services.Services;

public class ReviewQuestionService : GenericService<ReviewQuestion>, IReviewQuestionService
{
    public ReviewQuestionService(IAppDbContext dbContext) : base(dbContext)
    {
    }
}