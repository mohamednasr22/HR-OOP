using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.Entities
{
    internal class SalariedEmployee : Employee
    {
        public decimal BasicSalary { get; set; }
        public decimal Transportation { get; set; }
        public decimal Housing { get; set; }

        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[]
            {
                new PayItem("BasicSalary",BasicSalary),
                new PayItem("Transportation", Transportation),
                new PayItem("Housing", Housing)
            };
        }

        //dynamic polymorphism
        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return BasicSalary + Housing+ Transportation;
        }

        //static Polymorphism 
        //method overlode
        public decimal GetSalary(int taxPercentage)
        {
            decimal after_sale = ((BasicSalary * taxPercentage) / 100);
            return GetSalary()- after_sale;
        }
        public decimal GetSalary(int taxPercentage,int bouns)
        {
            
            return GetSalary( taxPercentage)+bouns;
        }
    }
}
