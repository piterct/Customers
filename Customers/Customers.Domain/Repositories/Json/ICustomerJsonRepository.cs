using Customers.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customers.Domain.Repositories.Json
{
    public interface ICustomerJsonRepository
    {
        Task<List<Customer>> SortCustomersByName();
        Task<Customer> GetCustomerById(int idCustomer);
    }
}
