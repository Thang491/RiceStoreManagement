using BussinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class SupplierDAO
    {

        public static List<Supplier> getListSupplier()
        {
            List<Supplier> list = new List<Supplier>();
            try
            {
                using var db = new RiceStoreManagerContext();
                list = db.Suppliers.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;

        }



        public static Supplier getSupplier(int index)
        {
            Supplier supplier = new Supplier();
            try
            {
                using var db = new RiceStoreManagerContext();
                var list = db.Suppliers.ToList();
                supplier = list[index];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return supplier;
        }

        public static void addSupplier(Supplier supplier)
        {
            try
            {
                using var db = new RiceStoreManagerContext();
                db.Suppliers.Add(supplier);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public static void UpdateSupplier(Supplier supplier)
        {
            try
            {
                using var db = new RiceStoreManagerContext();
                db.Entry<Supplier>(supplier).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void deleteSupplier(int index)
        {
            try
            {
                using var db = new RiceStoreManagerContext();
                var supplier = db.Suppliers.ToList()[index];
                db.Remove(supplier);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

