using Practice.BusinessLogicLayer.Data;
using Practice.DataAccessLayer.Entities;

namespace Practice.BusinessLogicLayer.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddCustomer(Customer customer)
        {
            if(customer is not null)
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            if(customer is not null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customers.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateCustomer(Customer customer)
        {
            if(customer is not null)
            {
                _context.Customers.Update(customer);
                _context.SaveChanges();
            }
        }
    }
}
