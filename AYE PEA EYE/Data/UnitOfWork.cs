using AYE_PEA_EYE.Data.Interfaces;
using AYE_PEA_EYE.Data.Repos.Interfaces;

namespace AYE_PEA_EYE.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _context;

        public ICustomerRepo CustomerRepo { get; private set; }

        public UnitOfWork(AppDbContext context, ICustomerRepo customerRepo)
        {
            _context = context;

            CustomerRepo = customerRepo;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
