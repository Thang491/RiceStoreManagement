using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IProductRepository
    {
        public IEnumerable<Product> getListProduct();
        public Product getProduct(int index);
        public void Addproduct(Product product);
        public void Deleteproduct(int index);
        public void UpdateProduct(Product product);
        public Product getProductbyId(int? id);
    }
}
