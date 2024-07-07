using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CaseProcess.Infra.Context;

public static class ProcessDbExtension
{
    public static void AddApplicationDbContext(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<ProcessDbContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });
    }
}