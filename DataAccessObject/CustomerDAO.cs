using BussinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class CustomerDAO
    {
        public static List<Customer> getListCustomer()
        {
            List<Customer> list = new List<Customer>();
            try
            {
                using var db = new RiceStoreManagerContext();
                list = db.Customers.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;

        }



        public static Customer getCustomer(int index)
        {
            Customer customer = new Customer();
            try
            {
                using var db = new RiceStoreManagerContext();
                var list = db.Customers.ToList();
                customer = list[index];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customer;
        }

        public static void addCustomer(Customer customer)
        {
            try
            {
                using var db = new RiceStoreManagerContext();
                db.Customers.Add(customer);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public static void UpdateCustomer(Customer customer)
        {
            try
            {
                using var db = new RiceStoreManagerContext();
                db.Entry<Customer>(customer).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void deleteCustomer(int index)
        {
            try
            {
                using var db = new RiceStoreManagerContext();
                var Customer = db.Customers.ToList()[index];
                db.Remove(Customer);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
