using Application.Interfaces.Persistance;
using Application.Interfaces.Services;
using EmployeeReview.Domain.Models.Entities;

namespace Infrastructure.Services.Services;

public class QuestionAnswerService : GenericService<QuestionAnswer>, IQuestionAnswerService
{
    public QuestionAnswerService(IAppDbContext dbContext) : base(dbContext)
    {
    }
}