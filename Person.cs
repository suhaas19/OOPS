using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Person
    {
        public string firstName;
        public string lastName;
        public static string salutation = "Mr.";
        public string sal;
      


        public Person()
        {
            firstName = "Suhaas";
            lastName = "Nagaralla";
            sal = salutation;
        }

        public Person(string sal,string fName, string lName)
        {
            this.sal = salutation;
            firstName =fName;  
            lastName = lName;
        }


        public string getName()
        {
            return firstName + " " + lastName;
        }
    }
}
