using Customers.Domain.Commands.Customer;
using Customers.Domain.Entities;
using Customers.Domain.Queries;
using Customers.Domain.Repositories.Json;
using Customers.Infra.Json.Json.Customer;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.Infra.Json.Repositories
{
    public class CustomerJsonRepository : ICustomerJsonRepository
    {
        public async ValueTask<CustomerEntity> GetCustomerById(int idCustomer)
        {
            var customers = JsonConvert.DeserializeObject<CustomerQuery>(CustomerResource.Customers);

            return await Task.FromResult(customers.Clientes.Where(x => x.Id == idCustomer).FirstOrDefault());
        }

        public async ValueTask<CustomerEntity> GetCustomerByCpf(GetCustomerByCPFCommandInput command)
        {
            var customers = JsonConvert.DeserializeObject<CustomerQuery>(CustomerResource.Customers);

            return await Task.FromResult(customers.Clientes.Where(x => x.Cpf == command.CPF).FirstOrDefault());
        }

        public async ValueTask<List<CustomerEntity>> SortCustomersByName()
        {
            var customers = JsonConvert.DeserializeObject<CustomerQuery>(CustomerResource.Customers);

            return await Task.FromResult(customers.Clientes);
        }

    }
}

