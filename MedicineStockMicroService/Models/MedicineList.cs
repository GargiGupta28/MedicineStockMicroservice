using System;
using System.Collections.Generic;

namespace MedicineStockMicroService.Models
{
    public static class MedicineList
    {
        public static List<Medicine> medicines = new List<Medicine>()
        {
            new Medicine{ Name = "Gaviscon", ChemicalComposition = new string[2]{"A","B"}, TargetAilment ="General", DateOfExpiry = new DateTime(2021, 12, 31), NumberOfTabletsInStock =100000 },
            new Medicine{ Name = "Dolo-650", ChemicalComposition = new string[2]{"C","D"}, TargetAilment ="General", DateOfExpiry = new DateTime(2021, 12, 30), NumberOfTabletsInStock =95000 },
            new Medicine{ Name = "Hilact", ChemicalComposition = new string[2]{"E","F"}, TargetAilment ="Gynaecology", DateOfExpiry = new DateTime(2021, 12, 29), NumberOfTabletsInStock =85000 },
            new Medicine{ Name = "Cyclopam", ChemicalComposition = new string[2]{"G","H"}, TargetAilment ="Gynaecology", DateOfExpiry = new DateTime(2021, 12, 28), NumberOfTabletsInStock =97000 },
            new Medicine{ Name = "Orthoherb", ChemicalComposition = new string[2]{"I","J"}, TargetAilment ="Orthopaedics", DateOfExpiry = new DateTime(2021, 12, 27), NumberOfTabletsInStock =94500 },
            new Medicine{ Name = "Cholecalciferol", ChemicalComposition = new string[2]{"K","L"}, TargetAilment ="Orthopaedics", DateOfExpiry = new DateTime(2021, 12, 26), NumberOfTabletsInStock =75000 }
        };
    }
}