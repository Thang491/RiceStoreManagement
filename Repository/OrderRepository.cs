using BussinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OrderRepository:IOrderRepository
    {
        public List<Order> getListOrder() => OrderDAO.getListOrder();
        public Order getOrder(int index)=> OrderDAO.getOrder(index);
        public void addOrder(Order order)=> OrderDAO.addOrder(order);
        public void UpdateOrder(Order order)=> OrderDAO.UpdateOrder(order);
        public void deleteOrder(int index)=> OrderDAO.deleteOrder(index);
    }
}
