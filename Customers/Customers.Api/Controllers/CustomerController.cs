using Customers.Domain.Repositories.Json;
using Customers.Shared.Commands;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
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
        public async ValueTask<IActionResult> GetCustomers()
        {
            try
            {
                var customers = await _customerJsonRepository.GetCustomers();

                return GetResult(new GenericCommandResult(true, "Success", customers, StatusCodes.Status200OK, null));
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
