using Customers.Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Customers.Api.Helpers.JsonFile.Customers
{
    public static class CustomerJsonSettings
    {
        public static void AppSettings(this IServiceCollection services, IConfiguration configuration)
        {
            #region IOptions
            services.Configure<Customer>(configuration.GetSection("clientes"));
            #endregion
        }
    }
}
