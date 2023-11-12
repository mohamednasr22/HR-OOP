using Hr.Entities;

namespace Hr
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var salariedEmployee = new SalariedEmployee();
            salariedEmployee.SetName ("mohamed","Ahmed");
            salariedEmployee.SetEmail ( "MohamedAhm@nasr.com");
            salariedEmployee.BasicSalary = 100;
            salariedEmployee.Housing = 20;
            salariedEmployee.Transportation = 10;

            Console.WriteLine($"Salary for  {salariedEmployee.FirstName} {salariedEmployee.LastName} is {salariedEmployee.GetSalary(2,5)}");





            var HourlyEmployee = new HourlyEmployee();
            HourlyEmployee.SetName ("Ahmed","Ahmed");
            HourlyEmployee.SetEmail("AhmedAhmed@nasr.com");
            HourlyEmployee.HoursRate=5;
            HourlyEmployee.TotalWorkHours = 30;
            Console.WriteLine($"Salary for  {HourlyEmployee.FirstName} {HourlyEmployee.LastName} is {HourlyEmployee.GetSalary()}");




            var internEmployee = new InternEmployee();
            internEmployee.SetName ("Mohamed", "Mohamed");
            internEmployee.SetEmail ("MohamedEmp@nasr.com");
            Console.WriteLine($"Salary for  {internEmployee.FirstName} {internEmployee.LastName} is {internEmployee.GetSalary()}");

            Console.WriteLine("-------------------++++++++++++++++");

            // abstraction
            var notifer = new Notifier("mail@exmple.com", 25, "mail2@exmple.com", "P@ssw0rd");
            var payslipGenerator = new PaySlipGenerator(notifer);
            payslipGenerator.Generate(salariedEmployee);
            payslipGenerator.Generate(HourlyEmployee);
            payslipGenerator.Generate(internEmployee);






            //encapsolation

            //var employee = new Employee();
            //employee.SetName("Ibrahim", "nasr");
            ////employee.SetBirthDate(new DateOnly(1555,5,5));
            //employee.SetBirthDate(new DateOnly(2000,5,5));
            //employee.BasicSalary= 9555;
            //employee.TaxPercentage= 95;
            //var applicant = new Applicant();
            //applicant.SetName("mos", "nasr");
            ////employee.SetBirthDate(new DateOnly(1555,5,5));
            //applicant.SetBirthDate(new DateOnly(2002,5,5));

            //printPersonDetails(employee);
            //printPersonDetails(applicant);


            //Person p = employee;
            //p = applicant;
            //Console.WriteLine($"birth is {p.BirthDay}");


        }

        private static void printPersonDetails(Person employee)
        {
            Console.WriteLine($"Name is {employee.FirstName} {employee.LastName}");
            Console.WriteLine($"birth is {employee.BirthDay}");
            //Console.WriteLine($"BasicSalary is {employee.BasicSalary}:0.00");
            //Console.WriteLine($"TaxPercentage is {employee.TaxPercentage}%");
        }
    }
}

