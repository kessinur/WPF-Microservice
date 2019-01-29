using BootcampWPF.DataAccess.Model;
using BootcampWPF.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampWPF.BussinessLogic
{
    public interface ISupplierService
    {
        bool Insert(SupplierParam supplierParam);
        bool Update(int? id, SupplierParam supplierParam);
        bool Delete(int? id);
        List<Supplier> Get();
        Supplier Get(int? id);
    }
}
