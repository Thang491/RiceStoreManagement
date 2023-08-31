using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICustomerRepository
    {
        public List<Customer> getListCustomer();
        public Customer getCustomer(int index);
        public void addCustomer(Customer customer);
        public void UpdateCustomer(Customer customer);
        public  void deleteCustomer(int index);
    }
}
