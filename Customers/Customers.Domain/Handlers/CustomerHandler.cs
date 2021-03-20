using Customers.Domain.Commands.Customer;
using Customers.Domain.Entities;
using Customers.Domain.Repositories.Json;
using Customers.Shared.Commands;
using Customers.Shared.Commands.Contracts;
using Flunt.Notifications;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Customers.Domain.Handlers
{
    public class CustomerHandler : Notifiable, ICommandHandler<GetCustomerByCPFCommand>
    {
        private readonly ICustomerJsonRepository _customerJsonRepository;

        public CustomerHandler(ICustomerJsonRepository customerJsonRepository)
        {
            _customerJsonRepository = customerJsonRepository;
        }


        public async ValueTask<ICommandResult> Handle(GetCustomerByCPFCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Incorrect  data!", null, StatusCodes.Status400BadRequest, command.Notifications);

            Customer customerRepository = await _customerJsonRepository.GetCustomerByCpf(command);

            if (customerRepository == null)
                return new GenericCommandResult(false, "NotFound", null, StatusCodes.Status404NotFound, command.Notifications);

            Customer customer = new Customer(customerRepository.Id, customerRepository.Nome, customerRepository.Cpf, customerRepository.Salario);

            customer.SalaryCustomerCalculation();

            return new GenericCommandResult(true, "Success!", customer, StatusCodes.Status200OK, command.Notifications);
        }


    }


}
