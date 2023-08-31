using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ISupplierRepository
    {
        public List<Supplier> getListSupplier();
        public Supplier getSupplier(int index);
        public void addSupplier(Supplier supplier);
        public void UpdateSupplier(Supplier supplier);
        public void deleteSupplier(int index);
    }
}
