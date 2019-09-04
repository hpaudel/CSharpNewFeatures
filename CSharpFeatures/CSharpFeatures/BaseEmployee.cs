using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BaseEmployee:BasePerson
    {
        public string id = "ABC567EFG";
        public override void GetInfo()
        {
            // Calling the base class GetInfo method:
            base.GetInfo();
            Console.WriteLine("Employee ID: {0}", id);
        }
    }
}
