using Application.Interfaces.Persistance;
using EmployeeReview.Domain.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services.Persistance;

public class AppDbContext : IdentityDbContext<ApplicationUser>, IAppDbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<ReviewQuestion> ReviewQuestions { get; set; }
    public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
    public DbSet<Review> Reviews { get; set; }
}