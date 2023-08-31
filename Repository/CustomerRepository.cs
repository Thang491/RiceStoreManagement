using BussinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CustomerRepository: ICustomerRepository
    {
        public List<Customer> getListCustomer()=> CustomerDAO.getListCustomer();
        public  Customer getCustomer(int index)=> CustomerDAO.getCustomer(index);
        public  void addCustomer(Customer customer)=> CustomerDAO.addCustomer(customer);
        public void UpdateCustomer(Customer customer)=> CustomerDAO.UpdateCustomer(customer);
        public  void deleteCustomer(int index)=> CustomerDAO.deleteCustomer(index);

    }
}
