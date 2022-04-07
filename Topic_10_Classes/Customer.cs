using System.Collections.Generic;

namespace Topic_10_Classes
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAdress { get; set; }

        public static int Counter { get; set; }

        public Customer(){ }

        public Customer(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public Customer(string firstname, string lastname, string emailAddress)
        {
            Firstname = firstname;
            Lastname = lastname;
            EmailAddress = emailAddress;
        }

        public bool Validate() 
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(Firstname)) 
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(Lastname)) 
            {
                isValid = false;
            }

            return isValid;
        }

        public string GetFullName() 
        {
            return Firstname + ", " + Lastname;
        }
    }
}
