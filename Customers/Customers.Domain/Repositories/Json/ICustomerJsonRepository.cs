using Customers.Domain.Commands.Customer;
using Customers.Domain.Commands.Inputs;
using Customers.Shared.Settings;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customers.Domain.Repositories.Json
{
    public interface ICustomerJsonRepository
    {
        ValueTask<List<CustomersJson>> SortCustomersByName();
        ValueTask<CustomersJson> GetCustomerById(GetCustomerByIdCommandInput command);
        ValueTask<CustomersJson> GetCustomerByCpf(GetCustomerByCPFCommandInput command);
    }
}
