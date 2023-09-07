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

        [HttpPost]
        public JsonResult SetPatient(string FirstName, string LastName, int age, string Address, int ptype)
        {
            ICreateObj obj;
            Ipatient objipatient;
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
            objipatient = obj.GetObj();
            Patient ptn = new Patient();
            ptn.FirstName = objipatient.FirstName(FirstName);
            ptn.LastName = objipatient.LastName(LastName);
            ptn.Age = objipatient.Age(age);
            ptn.Adrress = objipatient.Address(Address);
            ptn.PatientType = objipatient.Typ();
            _context.Patients.Add(ptn);
            _context.SaveChanges();

            return Json(ptn);
            //return Json(objipatient.FirstName(FirstName) + " " + objipatient.LastName(LastName) + ", Age: " + objipatient.Age(age) + ", Address: "+ objipatient.Address(Address) + ", " + objipatient.Typ());
        }

        [HttpGet]
        public JsonResult getPatient(int Id)
        {
            ICreateObj obj;
            Patient? ptn = new Patient();
            ptn = _context.Patients.Where(x => x.Id == Id).SingleOrDefault();
            return Json(ptn);
        }
    }
}
