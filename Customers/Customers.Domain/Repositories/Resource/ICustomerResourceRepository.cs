using Customers.Domain.Commands.Customer;
using Customers.Domain.Commands.Inputs;
using Customers.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customers.Domain.Repositories.Resource
{
    public interface ICustomerResourceRepository
    {
        ValueTask<List<Customer>> SortCustomersByName();
        ValueTask<Customer> GetCustomerById(GetCustomerByIdCommandInput command);
        ValueTask<Customer> GetCustomerByCpf(GetCustomerByCPFCommandInput command);
    }
}
