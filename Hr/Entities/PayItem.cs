using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.Entities
{
    internal class PayItem
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public PayItem(string name, decimal value)
        {

            Name = name;
            Value = value;

        }
    }
}
