using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootcampWPF.DataAccess.Model;
using BootcampWPF.DataAccess.Param;
using BootcampWPF.Common;
using BootcampWPF.Common.Interfaces.Master;

namespace BootcampWPF.BussinessLogic.Services.Master
{
    public class SupplierService : ISupplierService
    {
        ISupplierRepository _supplierRepository = new SupplierRepository();
        bool status = false;
        public bool Delete(int? id)
        {
            if (id == null)
            {
                Console.WriteLine("Please Insert Supplier Id");
                Console.Read();
            }
            else if (id == ' ')
            {
                Console.WriteLine("Don't insert blank character");
                Console.Read();
            }
            else
            {
                status = _supplierRepository.Delete(id);
                Console.WriteLine("Delete Successfully");
                Console.Read();
            }
            return status;
        }

        public List<Supplier> Get()
        {
            return _supplierRepository.Get();
        }

        public Supplier Get(int? id)
        {
            var getSupplierId = _supplierRepository.Get(id);
            if (getSupplierId == null)
            {
                Console.WriteLine("Please Insert Supplier Id");
                Console.Read();
            }
            return getSupplierId;
        }

        public bool Insert(SupplierParam supplierParam)
        {
            if (supplierParam == null)
            {
                Console.WriteLine("Please Insert Supplier");
                Console.Read();
            }
            if (supplierParam.ToString() == " ")
            {
                Console.WriteLine("Don't insert blank character");
                Console.Read();
            }
            else
            {
                status = _supplierRepository.Insert(supplierParam);
                Console.WriteLine("Insert Succesfully");
                Console.Read();
            }
            return status;
        }

        public bool Update(int? id, SupplierParam supplierParam)
        {
            if (id == null)
            {
                Console.WriteLine("Please Insert Supplier Id");
                Console.Read();
            }
            if (id.ToString() == " ")
            {
                Console.WriteLine("Don't insert blank character");
                Console.Read();
            }
            else
            {
                status = _supplierRepository.Update(id, supplierParam);
                Console.WriteLine("Update Succesfully");
                Console.Read();
            }
            return status;
        }
    }
}
