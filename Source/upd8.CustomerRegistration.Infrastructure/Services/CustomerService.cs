using Microsoft.EntityFrameworkCore;
using upd8.CustomerRegistration.Domain.Entities;
using upd8.CustomerRegistration.Infrastructure.Data;

namespace upd8.CustomerRegistration.Infrastructure.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly DataContext _dbContext;

        public CustomerService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Customer customer)
        {
            await _dbContext.AddAsync(customer);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(Customer customer)
        {
             _dbContext.Update(customer);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Customer customer)
        {
            _dbContext.Remove(customer);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Customer> GetBy(Guid id)
        {
            var customer = await _dbContext.Customers.FirstOrDefaultAsync(c => c.Id == id);
            return customer;
        }

        public async Task<List<Customer>> GetAll()
        {
            var customers = await _dbContext.Customers.ToListAsync();
            return customers;
        }
    }
}
