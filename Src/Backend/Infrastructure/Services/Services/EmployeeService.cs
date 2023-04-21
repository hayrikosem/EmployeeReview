using Application.Interfaces.Persistance;
using Application.Interfaces.Services;
using EmployeeReview.Domain.Models.Entities;

namespace Infrastructure.Services.Services
{
    public class EmployeeService : GenericService<Employee>, IEmployeeService

    {
        public EmployeeService(IAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}