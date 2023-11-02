using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Crm.DataAccess;

public static class ServiceExtension
{
    public static void ConfigureDataAcces(this IServiceCollection services)
    {
        services.AddDbContext<CrmDbContext>(
            opt => opt.UseNpgsql(DatabaseHelper.ConnectionString));

        services.AddScoped<IOrderRepository, EfCoreOrderRepository>();
    }
}