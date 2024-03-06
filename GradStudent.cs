using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class GradStudent : Student, BestPrac
    {
        public string Study()
        {
            return "Next week G Ramp";
        }
        public string Rest()
        {
            return "After Sat Take rest";
        }
    }
}
