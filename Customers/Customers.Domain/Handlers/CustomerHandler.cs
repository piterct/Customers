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

            var customer = await _customerJsonRepository.GetCustomerByCpf(command);

            if (customer == null)
                return new GenericCommandResult(false, "NotFound", null, StatusCodes.Status404NotFound, command.Notifications);

            customer = await SalaryCustomerCalculation(customer);

            return new GenericCommandResult(true, "sucess!", customer, StatusCodes.Status200OK, command.Notifications);
        }


        #region Private Methods

        private async ValueTask<Customer> SalaryCustomerCalculation(Customer customer)
        {
            customer.Salario = Math.Round(customer.Salario * 0.30M, 2);

            return await Task.FromResult(customer);
        }

        #endregion
    }


}
