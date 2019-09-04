using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Engineer : IEmployee
    {
        
        public double Salary { get; set; }

        public double CalculateBonus()
        {
            return Salary * 0.1;
        }
    }
}
