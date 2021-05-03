using Customers.Domain.Commands.Customer;
using Customers.Domain.Commands.Inputs;
using Customers.Domain.Entities;
using Customers.Domain.Queries;
using Customers.Domain.Repositories.Resource;
using Customers.Infra.Resource.Resource.Customer;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.Infra.Json.Repositories
{
    public class CustomerResourceRepository : ICustomerResourceRepository
    {
        public async ValueTask<CustomerEntity> GetCustomerById(GetCustomerByIdCommandInput command )
        {
            var customers = JsonConvert.DeserializeObject<CustomerQuery>(CustomerResource.Customers);

            return await Task.FromResult(customers.Clientes.Where(x => x.Id == command.IdCustomer).FirstOrDefault());
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

