using Customers.Shared.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Customers.Api.Controllers
{
    public class BaseController: Controller
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult GetResult(GenericCommandResult result) => StatusCode(result.StatusCode, result);
    }
}
