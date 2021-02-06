using MedicineStockMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStockMicroService.Repository
{
    public interface IMedicineListRepository
    {
        public List<Medicine> GetMedicines();
    }
}
