using AYE_PEA_EYE.Controllers.Services.Interfaces;
using AYE_PEA_EYE.Models;
using Microsoft.AspNetCore.Mvc;

namespace AYE_PEA_EYE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ICustomerService customerService, ILogger<CustomerController> logger)
        {
            _customerService = customerService;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Customers))]
        public IActionResult GetCustomers()
        {
            var customerList = _customerService.GetAllCustomers();

            return Ok(customerList);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateCustomer([FromForm] Customers customer)
        {
            _customerService.CreateCustomer(customer.FirstName, customer.LastName, customer.Email);

            return Ok();
        }

    }
}
