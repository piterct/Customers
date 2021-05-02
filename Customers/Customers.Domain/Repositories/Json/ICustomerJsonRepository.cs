using Customers.Domain.Commands.Customer;
using Customers.Domain.Commands.Inputs;
using Customers.Domain.Entities;
using Customers.Shared.Settings;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customers.Domain.Repositories.Json
{
    public interface ICustomerJsonRepository
    {
        ValueTask<List<CustomerEntity>> SortCustomersByName();
        ValueTask<ClientesJson> GetCustomerById(GetCustomerByIdCommandInput command);
        ValueTask<CustomerEntity> GetCustomerByCpf(GetCustomerByCPFCommandInput command);
    }
}
