using Customers.Domain.Entities;
using Customers.Domain.Queries;
using Customers.Domain.Repositories.Json;
using Customers.Infra.Json.Json;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.Infra.Json.Repositories
{
    public class CustomerJsonRepository : ICustomerJsonRepository
    {
        public async Task<Customer> GetCustomerById(int idCustomer)
        {
            var customers = JsonConvert.DeserializeObject<CustomerQuery>(CustomerResource.Customers);

            return await Task.FromResult(customers.Clientes.Where(x => x.Id == idCustomer).FirstOrDefault());
        }

        public async Task<List<Customer>> SortCustomersByName()
        {
            var customers = JsonConvert.DeserializeObject<CustomerQuery>(CustomerResource.Customers);

            return await Task.FromResult(customers.Clientes);
        }
    }
}

