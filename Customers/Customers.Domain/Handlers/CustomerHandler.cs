using Customers.Domain.Repositories.Json;
using Customers.Shared.Commands.Contracts;
using Flunt.Notifications;
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

        public Task<ICommandResult> Handle(int command)
        {
            throw new System.NotImplementedException();
        }
    }
}
