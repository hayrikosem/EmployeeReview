using Infrastructure;
using Infrastructure.Services.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Api;
public static class BuildExtentions
{
    public static IApplicationBuilder  MigrateDatabase(this IApplicationBuilder app)
    {
        using (var scope = app.ApplicationServices.CreateScope())
        {
            var dbcontext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            dbcontext.Database.Migrate();
        }
        return app;
    }
    public static IApplicationBuilder SeedData(this IApplicationBuilder app)
    {
        using (var scope = app.ApplicationServices.CreateScope())
        {
            var services = scope.ServiceProvider.GetRequiredService<SeedData>();
            var dbcontext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            services.Seed(dbcontext).GetAwaiter().GetResult();

        }
        return app;
    }
}
