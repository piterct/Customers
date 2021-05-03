using Customers.Domain.Commands.Customer;
using Customers.Domain.Commands.Inputs;
using Customers.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customers.Domain.Repositories.Resource
{
    public interface ICustomerResourceRepository
    {
        ValueTask<List<CustomerEntity>> SortCustomersByName();
        ValueTask<CustomerEntity> GetCustomerById(GetCustomerByIdCommandInput command);
        ValueTask<CustomerEntity> GetCustomerByCpf(GetCustomerByCPFCommandInput command);
    }
}
