using Customers.Domain.Entities;
using Customers.Domain.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customers.Domain.Repositories.Json
{
    public interface ICustomerJsonRepository
    {
        ValueTask<List<Customer>> GetCustomers();
    }
}
