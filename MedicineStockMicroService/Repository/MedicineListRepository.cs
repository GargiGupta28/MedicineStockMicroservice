using MedicineStockMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStockMicroService.Repository
{
    public class MedicineListRepository:IMedicineListRepository
    {
        public List<Medicine> GetMedicines()
        {
            return MedicineList.medicines;
        }
    }
}
