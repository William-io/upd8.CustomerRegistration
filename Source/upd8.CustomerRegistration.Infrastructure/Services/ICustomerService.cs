using upd8.CustomerRegistration.Domain.Entities;

namespace upd8.CustomerRegistration.Infrastructure.Services
{
    public interface ICustomerService
    {
        Task Add(Customer customer);
        Task Update(Customer customer);
        Task Delete(Customer customer);
        Task<Customer> GetBy(Guid id);
        Task<List<Customer>> GetAll();
    }
}
