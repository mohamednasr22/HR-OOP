using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.Entities
{
    internal class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        [EmailAddress]
        public string email { get; private set; }
        public void SetEmail(string _email)
        {
            if (IsValidEmail(_email))
            {
                email = _email;
            }
            else
            {
                throw new ArgumentException("Invalid email address");
            }
        }
        public void SetName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Invalid Name");

            FirstName = firstName;
            LastName = lastName;

        }
        public DateOnly BirthDay { get;  set; }
        public void SetBirthDate(DateOnly birthDate)
        {
            if (birthDate < new DateOnly(1986, 9, 17))
            {
                throw new ArgumentException("Invalid birth date");
            }
            BirthDay = birthDate;
        }
        private bool IsValidEmail(string email)
        {
            // You can use a regular expression or a more sophisticated validation method
            // to check if the email is in a valid format.
            // This is a basic example, and you can improve it as needed.
            return email.Contains("@") && email.Contains(".");
        }
    }
}
