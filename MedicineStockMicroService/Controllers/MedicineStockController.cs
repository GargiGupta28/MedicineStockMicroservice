using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MedicineStockMicroService.Models;
using MedicineStockMicroService.Services;

namespace MedicineStockMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineStockController : ControllerBase
    {
        private readonly IMedicineListService _medicineListService;
        public MedicineStockController(IMedicineListService medicineListService)
        {
            _medicineListService = medicineListService;
        }
        //[Authorize] //Add authorization as needed
        [HttpGet("GetMedicine")]
        public IActionResult GetMedicine()
        {
            return Ok(_medicineListService.GetMedicines());
        }

        //[AllowAnonymous] //Enable this if authorization is implemented
        [HttpGet("Run")]
        public ActionResult<string> Get()
        {
            return "The Medicine Stock MicroService API is Running";
        }
    }
}
