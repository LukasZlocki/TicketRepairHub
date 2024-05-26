using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TicketRepairHub.Infrastructure.Persistance;
using TicketRepairHub.Infrastructure.Seeders;

namespace TicketRepairHub.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepairTicketDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("RepairingTicketConnectionString")));

            services.AddScoped<TicketRepairHubSeeder> seeder
        }
    }
}
