using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Student : Person
    {
        public string Snum;
        private string SSN;

        public Student()
        {
            Snum="U15906773";
        }

        public string getSSN()
        {
            return SSN;
        }

        public void setSSN(string val)
        {
            SSN = val;
        }
    }
}
