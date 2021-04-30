using Customers.Domain.Commands.Customer;
using Customers.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customers.Domain.Repositories.Json
{
    public interface ICustomerJsonRepository
    {
        ValueTask<List<CustomerEntity>> SortCustomersByName();
        ValueTask<CustomerEntity> GetCustomerById(int idCustomer);
        ValueTask<CustomerEntity> GetCustomerByCpf(GetCustomerByCPFCommandInput command);
    }
}
