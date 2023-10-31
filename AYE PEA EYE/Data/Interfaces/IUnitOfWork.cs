using AYE_PEA_EYE.Data.Repos.Interfaces;

namespace AYE_PEA_EYE.Data.Interfaces
{
    public interface IUnitOfWork
    {
        ICustomerRepo CustomerRepo { get; }

        void Save();
    }
}