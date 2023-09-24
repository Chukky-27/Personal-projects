using MateCore.Services.Interface;
using MateData.DTO;
using MateData.Models;
using MateData.UserDbContext;


namespace MateCore.Implementation.CustomerLogic
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly CustomerDbContext _dbContext;

        public CustomerRepo(CustomerDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void CreateCustomer(CreateCustomerDTO createCustomerDTO)
        {
            var customer = new Customer()
            {
                CustomerId = Guid.NewGuid().ToString(),
                Name = createCustomerDTO.Name,
                Email = createCustomerDTO.Email,
                Address = createCustomerDTO.Address,
                PhoneNumber = createCustomerDTO.PhoneNumber,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsDeleted = false,
            };
            _dbContext.Add(customer);
            _dbContext.SaveChanges();
        }

        public Customer GetCustomerById(string id)
        {
            var customer = _dbContext.Customers2.SingleOrDefault(customer => customer.CustomerId == id);
            return customer;
        }

        public void DeleteCustomerById(string id)
        {

        }
    }

}
