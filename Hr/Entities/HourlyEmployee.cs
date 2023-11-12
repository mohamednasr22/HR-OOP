using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.Entities
{
    internal class HourlyEmployee: Employee
    {

        public decimal HoursRate { get; set; }
        public decimal TotalWorkHours  { get; set; }

        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[] { new PayItem("Total hours", GetSalary()) };
        }

        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            return HoursRate * TotalWorkHours;
        }
    }
}
