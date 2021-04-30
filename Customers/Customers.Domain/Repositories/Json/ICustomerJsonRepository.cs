using Customers.Domain.Commands.Customer;
using Customers.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customers.Domain.Repositories.Json
{
    public interface ICustomerJsonRepository
    {
        ValueTask<List<Customer>> SortCustomersByName();
        ValueTask<Customer> GetCustomerById(int idCustomer);
        ValueTask<Customer> GetCustomerByCpf(GetCustomerByCPFCommandInput command);
    }
}
