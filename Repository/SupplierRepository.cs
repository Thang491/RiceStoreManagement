using BussinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SupplierRepository: ISupplierRepository
    {
        public List<Supplier> getListSupplier()=> SupplierDAO.getListSupplier();
        public Supplier getSupplier(int index)=> SupplierDAO.getSupplier(index);
        public void addSupplier(Supplier supplier)=> SupplierDAO.addSupplier(supplier);
        public void UpdateSupplier(Supplier supplier)=> SupplierDAO.UpdateSupplier(supplier);

        public void deleteSupplier(int index)=> SupplierDAO.deleteSupplier(index);
    }
}
