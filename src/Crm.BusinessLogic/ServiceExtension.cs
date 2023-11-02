using Crm.DataAccess;
using Microsoft.Extensions.DependencyInjection;

namespace Crm.BusinessLogic;

public static class ServiceExtension
{
    public static void ConfigureCrmServices(this IServiceCollection services)
    {
        services.ConfigureDataAcces();

        services.AddSingleton<IClientService, ClientService>();
        services.AddTransient<IOrderService, OrderService>();
        services.AddTransient<IStatisticsService, StatisticsService>();
    }
}