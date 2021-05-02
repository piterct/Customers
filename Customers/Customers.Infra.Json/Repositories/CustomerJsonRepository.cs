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
        private readonly List<CustomersJson> _listClientesJson;
        public CustomerJsonRepository(IOptions<CustomerJsonSettings> customerJsonSettings)
        {
            _listClientesJson = customerJsonSettings.Value.CustomersJson;
        }
        public async ValueTask<CustomersJson> GetCustomerById(GetCustomerByIdCommandInput command)
        {
            return await Task.FromResult(_listClientesJson.Where(x => x.Id == command.IdCustomer).FirstOrDefault());
        }

        public async ValueTask<CustomersJson> GetCustomerByCpf(GetCustomerByCPFCommandInput command)
        {
            return await Task.FromResult(_listClientesJson.Where(x => x.Cpf == command.CPF).FirstOrDefault());
        }

        public async ValueTask<List<CustomersJson>> SortCustomersByName()
        {
            return await Task.FromResult(_listClientesJson);
        }

    }
}

