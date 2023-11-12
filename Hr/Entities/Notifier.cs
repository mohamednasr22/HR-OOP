using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.Entities
{
    internal class Notifier : INotifier
    {
        public string SmtpServer { get; set; }
        public int  Port { get; set; }
        public string SendAddress { get; set; }

        public string SendPassword { get; set; }
        public Notifier(string smtpServer,int port ,string sendAddress , string sendPassword ) 
        {
            SmtpServer = smtpServer;
            Port = port;
            SendAddress = sendAddress;
            SendPassword = sendPassword;

        }
        public void Notify(string email, string subject, string body)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"You've new email from `{SendAddress}`  with subject `{subject}`");
            Console.WriteLine(body);
            Console.WriteLine($"Message sent Successfully to  `{email}`");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
