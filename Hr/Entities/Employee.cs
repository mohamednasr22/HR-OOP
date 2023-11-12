using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.Entities
{
    internal abstract class Employee :Person
    {
        // encapsulation 
        // protect data from worng data  make it in vaild status
        // an authorization access






        //polyremphism

        //Polymorphism 
        //function 
        public abstract decimal GetSalary();
        public abstract IEnumerable<PayItem> GetPayItems();

    }
}
