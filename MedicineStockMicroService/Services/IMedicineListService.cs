using MedicineStockMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStockMicroService.Services
{
    public interface IMedicineListService
    {
        public List<Medicine> GetMedicines();
    }
}
