using Customers.Domain.Commands.Customer;
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
        public async ValueTask<Customer> GetCustomerById(int idCustomer)
        {
            var customers = JsonConvert.DeserializeObject<CustomerQuery>(CustomerResource.Customers);

            return await Task.FromResult(customers.Clientes.Where(x => x.Id == idCustomer).FirstOrDefault());
        }

        public async ValueTask<Customer> GetCustomerByCpf(GetCustomerByCPFCommand command)
        {
            var customers = JsonConvert.DeserializeObject<CustomerQuery>(CustomerResource.Customers);

            return await Task.FromResult(customers.Clientes.Where(x => x.Cpf == command.CPF).FirstOrDefault());
        }

        public async ValueTask<List<Customer>> SortCustomersByName()
        {
            var customers = JsonConvert.DeserializeObject<CustomerQuery>(CustomerResource.Customers);

            return await Task.FromResult(customers.Clientes);
        }
    }
}

