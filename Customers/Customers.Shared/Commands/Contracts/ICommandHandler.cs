using System.Threading.Tasks;

namespace Customers.Shared.Commands.Contracts
{
    public interface ICommandHandler<T> where T : ICommand
    {
        Task<ICommandResult> Handle(T command);
    }
}
