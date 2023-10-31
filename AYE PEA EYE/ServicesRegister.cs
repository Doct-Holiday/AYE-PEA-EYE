using AYE_PEA_EYE.Controllers.Services;
using AYE_PEA_EYE.Controllers.Services.Interfaces;
using AYE_PEA_EYE.Data;
using AYE_PEA_EYE.Data.Interfaces;
using AYE_PEA_EYE.Data.Repos;
using AYE_PEA_EYE.Data.Repos.Interfaces;

namespace AYE_PEA_EYE
{
    public static class ServicesRegister
    {

        public static void AddServices(this IServiceCollection services)
        {
            // Unit Of Work
            services.AddScoped<IUnitOfWork, UnitOfWork>();


            // Services
            services.AddScoped<ICustomerService, CustomerService>();

            // Repos
            services.AddScoped<ICustomerRepo, CustomerRepo>();
            
        }



    }
}
