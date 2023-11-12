using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.Entities
{
    internal class PaySlipGenerator
    {
        private readonly INotifier _notifier;
        public PaySlipGenerator(INotifier notifier)
        {
            _notifier = notifier;
        }
        public void Generate(Employee employee)
        {
            var payItems = employee.GetPayItems();
            var message = new StringBuilder();
            message.AppendLine($"Dear {employee.FirstName}{employee.LastName},");
            message.AppendLine($"Please find below your payslip details:");
            foreach (var payItem in payItems)
                message.AppendLine($"{payItem.Name}\t\t{payItem.Value}");
            _notifier.Notify(employee.email,"PaySlip Generated !" ,message.ToString());
        }
    }
}
