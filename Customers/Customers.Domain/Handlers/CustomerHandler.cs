using Customers.Domain.Commands.Customer;
using Customers.Domain.Commands.Output;
using Customers.Domain.Commands.Result;
using Customers.Domain.Entities;
using Customers.Domain.Repositories.Json;
using Customers.Domain.Repositories.Resource;
using Customers.Shared.Settings;
using Flunt.Notifications;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Customers.Domain.Handlers
{
    public class CustomerHandler : Notifiable
    {
        private readonly ICustomerJsonRepository _customerJsonRepository;
        private readonly ICustomerResourceRepository _customerResourceRepository;


        public CustomerHandler(ICustomerJsonRepository customerJsonRepository)
        {
            _customerJsonRepository = customerJsonRepository;
        }

        public async ValueTask<GetCustomerByCPFCommandResult> Handle(GetCustomerByCPFCommandInput command)
        {
            command.Validate();
            if (command.Invalid)
                return new GetCustomerByCPFCommandResult(false, "Incorrect  data!", null, StatusCodes.Status400BadRequest, command.Notifications);

            CustomersJson customerRepository = await _customerJsonRepository.GetCustomerByCpf(command);

            if (customerRepository == null)
                return new GetCustomerByCPFCommandResult(false, "NotFound", null, StatusCodes.Status404NotFound, command.Notifications);

            CustomerEntity customer = new CustomerEntity(customerRepository.Id, customerRepository.Name, customerRepository.Cpf, customerRepository.Salary);

            customer.SalaryCustomerCalculation();

            GetCustomerByCPFCommandOutput customerByCPFcommandOutput = new GetCustomerByCPFCommandOutput(customer.Id, customer.Name, customer.Cpf, customer.Salary);

            return new GetCustomerByCPFCommandResult(true, "Success!", customerByCPFcommandOutput, StatusCodes.Status200OK, command.Notifications);
        }


    }


}
