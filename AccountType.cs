using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BankOperation
{
    public class AccountType : LoginOperation
    {
        public string CreateAccount()
        {
            Console.WriteLine($"Enter '1' to open a Savings Account \nEnter '2' to open a Current Account \nEnter '3' to open a Fixed Deposit Account ");
            Thread.Sleep(1000);
            int accountType = int.Parse(Console.ReadLine());

            if (accountType == 1)
            {
                Savings(FirstName, LastName, Email, Gender);
            }

            if(accountType == 2) 
            {
                Current(FirstName, LastName, Email, Gender);
            }

            if(accountType == 3)
            {
                FixedDeposit(FirstName, LastName, Email, Gender);
            }
            return Convert.ToString( accountType);


            
        }
        public string Savings(string firstName, string lastName, string email, string gender)
        {
            Console.Write("Enter your First Name: ");
            FirstName = Console.ReadLine();
            Console.Write("Enter your Last Name: ");
            LastName = Console.ReadLine();
            Console.Write("Enter your Email Address: ");
            Email = Console.ReadLine();


            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;

            Console.WriteLine("You have successfully created an account");

            Login(Email, Password);


            return "";
        }

        public string Current(string firstName, string lastName, string email, string gender)
        {
            Console.Write("Enter your first name: ");
            FirstName = Console.ReadLine();
            Console.Write("Enter your last name");
            LastName = Console.ReadLine();
            Console.Write("Enter your Email Address: ");
            Email = Console.ReadLine();



            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;

            return "";
        }

        public string FixedDeposit(string firstName, string lastName, string email, string gender)
        {
            Console.Write("Enter your first name: ");
            FirstName = Console.ReadLine();
            Console.Write("Enter your last name");
            LastName = Console.ReadLine();
            Console.Write("Enter your Email Address: ");
            Email = Console.ReadLine();


            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;

            return "";
        }
    }
}
