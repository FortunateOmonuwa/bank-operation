using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOperation
{

    public class CustomerDetails
    {
       


       
        //Properties of my customers details

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public AccountDetails AccountDetails { get; set; }

        //Fields
        public string _firstName;
        public string _lastName;
        public string _gender;
        public int _age;
        public string _email;
    }
}
