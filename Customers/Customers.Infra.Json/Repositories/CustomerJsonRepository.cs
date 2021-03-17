using Customers.Domain.Entities;
using Microsoft.Extensions.Options;

namespace Customers.Infra.Json.Repositories
{
    public class CustomerJsonRepository
    {
        private readonly IOptions<Customer> _customer;

        public CustomerJsonRepository()
        {

        }
    }
}
