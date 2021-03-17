using Microsoft.Extensions.Configuration;
using System.IO;

namespace Customers.Api.Helpers.JsonFile.Customers
{
    public static class CustomerJson
    {
        public static void AppSettings()
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        }
    }
}
