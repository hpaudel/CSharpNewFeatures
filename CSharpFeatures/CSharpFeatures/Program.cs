using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {


            //base keyword features

            BaseEmployee E = new BaseEmployee();
            E.GetInfo();


            IEmployee e = new Engineer();
            IEmployee t = new Tester();

            e.Salary = 10000;
            t.Salary = 8000;

            Console.WriteLine("Bonus:Engineer: {0}", e.CalculateBonus());
            Console.WriteLine("Bonus:Tester: {0}", t.CalculateBonus());


            Console.ReadLine();
        }

       
    }


}
