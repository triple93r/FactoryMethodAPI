using FactoryMethodAPI2.Interfaces;

namespace FactoryMethodAPI2.Implements
{
    public class InPatient : Ipatient
    {
        public string Address(string ad)
        {
            return ad;
        }

        public int Age(int ag)
        {
            return ag;
        }

        public string FirstName(string fname)
        {
            return "inPatient : " + fname;
        }

        public string LastName(string lname)
        {
            return lname;
        }
    }
}
