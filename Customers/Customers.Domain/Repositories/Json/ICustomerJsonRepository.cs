using Customers.Domain.Entities;
using System.Threading.Tasks;

namespace Customers.Domain.Repositories.Json
{
    public interface ICustomerJsonRepository
    {
        ValueTask<Customer> GetCustomer();
    }
}
