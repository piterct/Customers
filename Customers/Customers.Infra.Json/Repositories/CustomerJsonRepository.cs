using Customers.Domain.Entities;
using Customers.Domain.Repositories.Json;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Customers.Infra.Json.Repositories
{
    public class CustomerJsonRepository : ICustomerJsonRepository
    {
        private readonly IOptions<Customer> _customer;

        public CustomerJsonRepository(IOptions<Customer> customer)
        {
            _customer = customer;
        }
        public ValueTask<Customer> GetCustomer()
        {
            throw new System.NotImplementedException();
        }
    }
}
