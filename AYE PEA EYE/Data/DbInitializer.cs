using AYE_PEA_EYE.Models;

namespace AYE_PEA_EYE.Data
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();

            if (dbContext.Customers.Any())
                return;

            var initialData = new Customers
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@test.com"
            };

            dbContext.Customers.Add(initialData);
            dbContext.SaveChanges();
        }
    }
}
