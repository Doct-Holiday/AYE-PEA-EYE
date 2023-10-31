using AYE_PEA_EYE.Models;

namespace AYE_PEA_EYE.Controllers.Services.Interfaces
{
    public interface ICustomerService
    {
        Customers CreateCustomer(string firstName, string lastName, string email);
        void DeleteCustomerById(int id);
        IEnumerable<Customers> GetAllCustomers();
        Customers GetCustomerById(int id);
    }
}