using Customers.Domain.Commands.Customer;
using Customers.Domain.Commands.Inputs;
using Customers.Domain.Commands.Output;
using Customers.Domain.Commands.Result;
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
        [ProducesResponseType(typeof(SortCustomerByNameCommandResult), StatusCodes.Status200OK)]
        public async ValueTask<IActionResult> GetCustomers()
        {
            try
            {
                var customers = await _customerJsonRepository.SortCustomersByName();

                return GetResult(new SortCustomerByNameCommandResult(true, "Success", customers.OrderBy(x => x.Nome).ToList(), StatusCodes.Status200OK, null));
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
        public async ValueTask<IActionResult> GetCustomers(int idCustomer)
        {
            try
            {
                var customer = await _customerJsonRepository.GetCustomerById(new GetCustomerByIdCommandInput { IdCustomer = idCustomer });

                if (customer == null)
                    return GetResult(new GetCustomerByIdCommandResult(false, "NotFound", null, StatusCodes.Status404NotFound, null));

                GetCustomerByIdCommandOutPut GetCustomerByCPFCommandOutput = new GetCustomerByIdCommandOutPut(customer.Id, customer.Nome, customer.Cpf, customer.Salario);

                return GetResult(new GetCustomerByIdCommandResult(true, "Success", GetCustomerByCPFCommandOutput, StatusCodes.Status200OK, null));
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
        [ProducesResponseType(typeof(GetCustomerByCPFCommandResult), StatusCodes.Status200OK)]
        public async ValueTask<IActionResult> GetCustomers([FromBody] GetCustomerByCPFCommandInput command, [FromServices] CustomerHandler handler)
        {
            try
            {
                var result = await handler.Handle(command);

                return GetResult(result);
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
