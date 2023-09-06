using FactoryMethodAPI2.Concrete;
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
        public JsonResult GetPatient(string FirstName, string LastName, int age, string Address, int ptype)
        {
            ICreateObj obj;
            switch (ptype)
            {
                    case 1:
                    obj = new PatientFactory1.CasualPatientFactory();
                    break;
                    case 2:
                    obj = new PatientFactory1.InPatientFactory();
                    break;
                    default :
                    obj = new PatientFactory1.OutPatientFactory();
                    break;
                    throw new ArgumentException();
            }
            Ipatient objipatient = obj.GetObj();
            return Json(objipatient.FirstName(FirstName) + " " + objipatient.LastName(LastName) + ", Age: " + objipatient.Age(age) + ", Address: "+ objipatient.Address(Address));
        }
    }
}
