using BussinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductRepository:IProductRepository
    {
        public IEnumerable<Product> getListProduct()=> ProductDAO.getListProduct();
        public  Product getProduct(int index) => ProductDAO.getProduct(index);
        public  void Addproduct(Product product) => ProductDAO.Addproduct(product);
        public  void Deleteproduct(int index) => ProductDAO.Deleteproduct(index);
        public void UpdateProduct(Product product) => ProductDAO.UpdateProduct(product);
        public Product getProductbyId(int? id) => ProductDAO.getProductbyId(id);

    }
}
