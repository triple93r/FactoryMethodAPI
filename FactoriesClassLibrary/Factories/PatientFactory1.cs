using FactoryMethodAPI2.Concrete;
using FactoryMethodAPI2.Data;
using FactoryMethodAPI2.Interfaces;

namespace FactoryMethodAPI2.Factories
{
    public class PatientFactory1
    {
        //private readonly ApplicationDBContext _context;
        //public PatientFactory1(ApplicationDBContext db)
        //{
        //    _context = db;
        //}
        public class InPatientFactory : ICreateObj
        {
            public Ipatient GetObj()
            {
                return new InPatient();
            }
        }

        public class OutPatientFactory : ICreateObj
        {
            public Ipatient GetObj()
            {
                return new OutPatient();
            }
        }
        public class CasualPatientFactory : ICreateObj
        {
            public Ipatient GetObj()
            {
                return new CasualPatient();
            }
        }
    }

   
}
