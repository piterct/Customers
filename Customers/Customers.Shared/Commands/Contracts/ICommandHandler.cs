using System.Threading.Tasks;
using System.Windows.Input;

namespace Customers.Shared.Commands.Contracts
{
    public interface ICommandHandler<T> where T : ICommand
    {
        ValueTask<ICommandResult> Handle(T command);
    }
}
