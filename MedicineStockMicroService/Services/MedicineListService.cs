using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicineStockMicroService.Models;
using MedicineStockMicroService.Repository;

namespace MedicineStockMicroService.Services
{
    public class MedicineListService:IMedicineListService
    {
        private readonly IMedicineListRepository _medicineListRepository;        
        public MedicineListService(IMedicineListRepository medicineListRepository)
        {
            _medicineListRepository = medicineListRepository;
        }
        public List<Medicine> GetMedicines()
        {
            return _medicineListRepository.GetMedicines();
        }
    }
}
