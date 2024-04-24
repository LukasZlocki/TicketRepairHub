using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TicketRepairHub.Infrastructure.Persistance;

namespace TicketRepairHub.Infrastructure.Extensions
{
    public class ServiceCollectionExtensions
    {
        public static class ServiceCollectionExtension
        {
            public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
            {
                services.AddDbContext<RepairTicketDbContext>(options => options.UseSqlServer(
                    configuration.GetConnectionString("ShopConnectionString")));
            }
        }
    }
}
