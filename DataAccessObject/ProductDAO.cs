using BussinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class ProductDAO
    {
        public static IEnumerable<Product> getListProduct()
        {    List<Product> list = new List<Product>();
            try
            {
                using var db = new RiceStoreManagerContext();
                /*list = db.Products.Include(f => f.Supplier).ToList();*/
                list = db.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;

        }
        public static Product getProduct(int index)
        {
            Product product = new Product();
            try
            {
                using var db = new RiceStoreManagerContext();
                var list = db.Products.ToList();
                product = list[index];

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public static Product getProductbyId(int? id)
        {
            Product product = new Product();
            try
            {
                using var db = new RiceStoreManagerContext();
                product = db.Products.SingleOrDefault(f => f.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public static void Addproduct(Product product)
        {          
            try
            {
                using var db = new RiceStoreManagerContext();
                db.Products.Add(product);
                db.SaveChanges();              
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }
        public static void UpdateProduct(Product product)
        {
            try
            {
                using var db = new RiceStoreManagerContext();
                db.Entry<Product>(product).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void Deleteproduct(int index)
        {
            try
            {
                using var db = new RiceStoreManagerContext();
                var product = db.Products.ToList()[index];
                db.Remove(product);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        
    }
}
