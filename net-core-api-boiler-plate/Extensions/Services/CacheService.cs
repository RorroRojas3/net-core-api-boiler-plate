using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace net_core_api_boiler_plate.Extensions.Services
{
    /// <summary>
    ///     Static CacheService class
    /// </summary>
    public static class CacheService
    {
        /// <summary>
        ///     Adds Distributed cache
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void AddCacheService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDistributedSqlServerCache(options =>
            {
                options.ConnectionString = configuration.GetConnectionString("AzureDB");
                options.SchemaName = "dbo";
                options.TableName = "Cache";
            });
        }
    }
}