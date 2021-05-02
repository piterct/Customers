using Customers.Domain.Commands.Customer;
using Customers.Domain.Commands.Output;
using Customers.Domain.Commands.Result;
using Customers.Domain.Entities;
using Customers.Domain.Repositories.Json;
using Customers.Shared.Settings;
using Flunt.Notifications;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customers.Domain.Handlers
{
    public class CustomerHandler : Notifiable
    {
        private readonly ICustomerJsonRepository _customerJsonRepository;
     

        public CustomerHandler(ICustomerJsonRepository customerJsonRepository)
        {
            _customerJsonRepository = customerJsonRepository;
        }

        public async ValueTask<GetCustomerByCPFCommandResult> Handle(GetCustomerByCPFCommandInput command)
        {
            command.Validate();
            if (command.Invalid)
                return new GetCustomerByCPFCommandResult(false, "Incorrect  data!", null, StatusCodes.Status400BadRequest, command.Notifications);

            CustomerEntity customerRepository = await _customerJsonRepository.GetCustomerByCpf(command);

            if (customerRepository == null)
                return new GetCustomerByCPFCommandResult(false, "NotFound", null, StatusCodes.Status404NotFound, command.Notifications);

            CustomerEntity customer = new CustomerEntity(customerRepository.Id, customerRepository.Nome, customerRepository.Cpf, customerRepository.Salario);

            customer.SalaryCustomerCalculation();

            GetCustomerByCPFCommandOutput customerByCPFcommandOutput = new GetCustomerByCPFCommandOutput(customer.Id, customer.Nome, customer.Cpf, customer.Salario);

            return new GetCustomerByCPFCommandResult(true, "Success!", customerByCPFcommandOutput, StatusCodes.Status200OK, command.Notifications);
        }


    }


}
