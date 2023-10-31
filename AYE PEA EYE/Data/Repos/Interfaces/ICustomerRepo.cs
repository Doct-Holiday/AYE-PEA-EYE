using AYE_PEA_EYE.Models;

namespace AYE_PEA_EYE.Data.Repos.Interfaces
{
    public interface ICustomerRepo
    {
        Customers CreateCustomer(Customers customer);
        void DeleteCustomerById(int id);
        IEnumerable<Customers> GetCustomers();
        Customers GetCustomersById(int id);
    }
}