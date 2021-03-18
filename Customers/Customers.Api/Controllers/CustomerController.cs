using Customers.Domain.Commands.Customer;
using Customers.Domain.Handlers;
using Customers.Domain.Repositories.Json;
using Customers.Shared.Commands;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CustomerController : BaseController
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly ICustomerJsonRepository _customerJsonRepository;
        public CustomerController(ILogger<CustomerController> logger, ICustomerJsonRepository customerJsonRepository)
        {
            _logger = logger;
            _customerJsonRepository = customerJsonRepository;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("SortCustomerByName")]
        public async ValueTask<IActionResult> GetCustomers()
        {
            try
            {
                var customers = await _customerJsonRepository.SortCustomersByName();

                return GetResult(new GenericCommandResult(true, "Success", customers.OrderBy(x => x.Nome), StatusCodes.Status200OK, null));
            }
            catch (Exception exception)
            {
                _logger.LogError("An exception has occurred at {dateTime}. " +
                 "Exception message: {message}." +
                 "Exception Trace: {trace}", DateTime.UtcNow, exception.Message, exception.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        [HttpGet]
        [AllowAnonymous]
        [Route("GetCustomerById")]
        public async ValueTask<IActionResult> GetCustomers(int IdCustomer)
        {
            try
            {
                var customer = await _customerJsonRepository.GetCustomerById(IdCustomer);

                if (customer == null)
                    return GetResult(new GenericCommandResult(false, "NotFound", customer, StatusCodes.Status404NotFound, null));

                return GetResult(new GenericCommandResult(true, "Success", customer, StatusCodes.Status200OK, null));
            }
            catch (Exception exception)
            {
                _logger.LogError("An exception has occurred at {dateTime}. " +
                 "Exception message: {message}." +
                 "Exception Trace: {trace}", DateTime.UtcNow, exception.Message, exception.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPatch]
        [AllowAnonymous]
        [Route("GetCustomerByCpf")]
        public async ValueTask<IActionResult> GetCustomers([FromBody] GetCustomerByCPFCommand command, [FromServices] CustomerHandler handler)
        {
            try
            {
                var result = await handler.Handle(command);

                return GetResult((GenericCommandResult)result);
            }
            catch (Exception exception)
            {
                _logger.LogError("An exception has occurred at {dateTime}. " +
                 "Exception message: {message}." +
                 "Exception Trace: {trace}", DateTime.UtcNow, exception.Message, exception.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
