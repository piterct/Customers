using Customers.Domain.Commands.Result;
using Customers.Shared.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Customers.Api.Controllers
{
    public class BaseController : Controller
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult GetResult(GenericCommandResult result) => StatusCode(result.StatusCode, result);
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult GetResult(GetCustomerByCPFCommandResult result) => StatusCode(result.StatusCode, result);
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult GetResult(SortCustomerByNameCommandResult result) => StatusCode(result.StatusCode, result);
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult GetResult(GetCustomerByIdCommandResult result) => StatusCode(result.StatusCode, result);
    }
}
