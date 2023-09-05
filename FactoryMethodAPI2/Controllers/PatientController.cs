using FactoryMethodAPI2.Data;
using FactoryMethodAPI2.Factories;
using FactoryMethodAPI2.Interfaces;
using FactoryMethodAPI2.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FactoryMethodAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : Controller
    {
        private readonly ApplicationDBContext _context;
        public PatientController(ApplicationDBContext db)
        {
            _context = db;
        }

        [HttpGet]
        public JsonResult GetPatient()
        {
            ICreateObj obj = new PatientFactory1.CasualPatientFactory();
            Ipatient objipatient = obj.GetObj();
            return Json(objipatient.FirstName("Anil") + objipatient.LastName(" kim") + objipatient.Age(26) + objipatient.Address("location"));
        }
    }
}
