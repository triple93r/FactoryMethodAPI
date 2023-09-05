using FactoryMethodAPI2.Interfaces;

namespace FactoryMethodAPI2.Implements
{
    public class OutPatient : Ipatient
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
            return "Out Patient : " + fname;
        }

        public string LastName(string lname)
        {
            return lname;
        }
    }
}
