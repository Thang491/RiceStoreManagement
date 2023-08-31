using BussinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class OrderDAO
    {
        public static List<Order> getListOrder()
        {
            List<Order> list = new List<Order>();
            try
            {
                using var db = new RiceStoreManagerContext();
                list = db.Orders.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;

        }



        public static Order getOrder(int index)
        {
            Order order = new Order();
            try
            {
                using var db = new RiceStoreManagerContext();
                order = db.Orders.ToList()[index];
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }

        public static void addOrder(Order order)
        {
            try
            {
                using var db = new RiceStoreManagerContext();
                db.Orders.Add(order);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public static void UpdateOrder(Order order)
        {
            try
            {
                using var db = new RiceStoreManagerContext();
                db.Entry<Order>(order).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void deleteOrder(int index)
        {
            try
            {
                using var db = new RiceStoreManagerContext();
                var order = db.Orders.ToList()[index];
                db.Remove(order);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       
    }
}
