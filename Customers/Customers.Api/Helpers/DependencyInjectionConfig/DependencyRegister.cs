using Customers.Domain.Handlers;
using Customers.Domain.Repositories.Json;
using Customers.Infra.Json.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Customers.Api.Helpers.DependencyInjectionConfig
{
    public static class DependencyRegister
    {
        public static void AddScoped(this IServiceCollection services, IConfiguration configuration)
        {

            #region Repositories
            services.AddTransient<ICustomerJsonRepository, CustomerJsonRepository>();
            #endregion

            #region Handlers
            services.AddTransient<CustomerHandler, CustomerHandler>();
            #endregion

        }
    }
}
