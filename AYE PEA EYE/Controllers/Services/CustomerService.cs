using AYE_PEA_EYE.Controllers.Services.Interfaces;
using AYE_PEA_EYE.Data.Interfaces;
using AYE_PEA_EYE.Models;

namespace AYE_PEA_EYE.Controllers.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CustomerService> _logger;

        public CustomerService(IUnitOfWork unitOfWork, ILogger<CustomerService> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public Customers CreateCustomer(string firstName, string lastName, string email)
        {
            Customers customer = new Customers()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email
            };

            _unitOfWork.CustomerRepo.CreateCustomer(customer);
            _unitOfWork.Save();

            return customer;
        }

        public IEnumerable<Customers> GetAllCustomers()
        {
            var customerList = _unitOfWork.CustomerRepo.GetCustomers();

            return customerList;
        }

        public Customers GetCustomerById(int id)
        {
            var customer = _unitOfWork.CustomerRepo.GetCustomersById(id);

            return customer;
        }

        public void DeleteCustomerById(int id)
        {
            _unitOfWork.CustomerRepo.DeleteCustomerById(id);
            _unitOfWork.Save();
        }

    }
}
