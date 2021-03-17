using Microsoft.Extensions.Configuration;
using System.IO;

namespace Customers.Api.Helpers.JsonFile.Customers
{
    public static class CustomerJsonSettings
    {
        public static void AppSettings()
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        }
    }
}
