using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tester : IEmployee
    {
       
        public double Salary { get; set; }
        public double CalculateBonus()
        {
            return Salary * .1;
        }
    }
}
