using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Models.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> Get(int? id);
        Task<List<Customer>> Get();
        Task<bool> Create(Customer customer);
        Task<bool> Edit(int id, Customer customer);
        Task<bool> Delete(int id);
        bool CustomerExists(int id);
    }
}
