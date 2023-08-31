using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IOrderRepository
    {
        public List<Order> getListOrder();
        public Order getOrder(int index);
        public void addOrder(Order order);
        public void UpdateOrder(Order order);
        public void deleteOrder(int index);
    }
}
