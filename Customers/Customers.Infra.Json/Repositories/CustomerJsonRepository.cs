using Customers.Domain.Commands.Customer;
using Customers.Domain.Commands.Inputs;
using Customers.Domain.Entities;
using Customers.Domain.Queries;
using Customers.Domain.Repositories.Json;
using Customers.Infra.Json.Json.Customer;
using Customers.Shared.Settings;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.Infra.Json.Repositories
{
    public class CustomerJsonRepository : ICustomerJsonRepository
    {
        private readonly List<ClientesJson> _listClientesJson;
        public CustomerJsonRepository(IOptions<CustomerJsonSettings> jsonSettings)
        {
            _listClientesJson = jsonSettings.Value.ClientesJson;
        }
        public async ValueTask<ClientesJson> GetCustomerById(GetCustomerByIdCommandInput command)
        {
            return await Task.FromResult(_listClientesJson.Where(x => x.Id == command.IdCustomer).FirstOrDefault());
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

