using MateData.DTO;
using MateData.Models;


namespace MateCore.Services.Interface
{
    public interface ICustomerRepo
    {
        void CreateCustomer(CreateCustomerDTO createCustomerDTO);
        Customer GetCustomerById(string id);
        void DeleteCustomerById(string id);
    }
}
