using Application.Interfaces.Services;
using EmployeeReview.Domain.Models.Entities;
using Infrastructure.Services.Persistance;
using Infrastructure.Services.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;


public static class DependencyInjectin
{
    public static void AddInfracstructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        // Add Identity
        services.AddIdentity<ApplicationUser, ApplicationRole>()
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();

        // Add your services to the DI container here
        services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<IReviewQuestionService, ReviewQuestionService>();
        services.AddScoped<IQuestionAnswerService, QuestionAnswerService>();
        services.AddScoped<IReviewService, ReviewService>();
    }
}