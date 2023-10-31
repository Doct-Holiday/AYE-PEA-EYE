using AYE_PEA_EYE.Data.Repos.Interfaces;
using AYE_PEA_EYE.Models;

namespace AYE_PEA_EYE.Data.Repos
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly AppDbContext _context;

        public CustomerRepo(AppDbContext context)
        {
            _context = context;
        }

        // CRUD
        public Customers CreateCustomer(Customers customer)
        {
            _context.Customers.Add(customer);

            return customer;
        }

        public IEnumerable<Customers> GetCustomers()
        {
            var customers = _context.Customers.ToList();

            return customers;
        }

        public Customers GetCustomersById(int id)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.Id == id);

            return customer;
        }

        public void DeleteCustomerById(int id)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.Id == id);

            _context.Customers.Remove(customer);
        }

    }
}
