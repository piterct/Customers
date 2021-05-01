using Customers.Shared.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace Customers.Domain.Commands.Inputs
{
    public class GetCustomerByIdCommandInput : Notifiable, ICommand
    {
        public int IdCustomer { get; set; }
        public void Validate()
        {
            AddNotifications(
           new Contract()
               .Requires()
               .AreEquals(IdCustomer, 0, "IdCustomer", "This value is not valid!")
                );
        }
    }
}
