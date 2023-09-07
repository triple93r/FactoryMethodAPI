using FactoryMethodAPI2.Interfaces;

namespace FactoryMethodAPI2.Concrete
{
    public class PatientClass
    {
        //This program is for testing dependency injection, but could not be applied to Factory method.
        public Ipatient ptAcct { get; set; }
        public string pAccount()
        {
            return ptAcct.FirstName("firstnm") + "," + ptAcct.LastName("lstnm");
        }
    }
}
