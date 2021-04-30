using Customers.Shared.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace Customers.Domain.Commands.Customer
{
    public class GetCustomerByCPFCommandInput : Notifiable, ICommand
    {
        public string CPF { get; set; }

        public void Validate()
        {
            AddNotifications(
           new Contract()
               .Requires()
               .IsNotNull(CPF,"CPF", "This value is not valid!")
                );
        }
    }
}
