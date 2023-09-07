using FactoryMethodAPI2.Interfaces;

namespace FactoryMethodAPI2.Concrete
{
    public class InPatient : Ipatient
    {
        public string Address(string ad)
        {
            return ad;
        }

        public string Age(int ag)
        {
            if (ag >= 18 && ag < 60) return "Adult";
            else if (ag >= 60) return "Senior";
            else return "Minor";
        }

        public string FirstName(string fname)
        {
            return fname;
        }

        public string LastName(string lname)
        {
            return lname;
        }

        public string Typ()
        {
            return "In Patient";
        }
    }
}
