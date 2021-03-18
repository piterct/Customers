using Customers.Domain.Repositories.Json;
using Flunt.Notifications;

namespace Customers.Domain.Handlers
{
    public class CustomerHandler : Notifiable
    {
        private readonly ICustomerJsonRepository _customerJsonRepository;

        public CustomerHandler(ICustomerJsonRepository customerJsonRepository)
        {
            _customerJsonRepository = customerJsonRepository;
        }


    }
}
