using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOperation
{
    public class LoginOperation : AccountOperations
    {
        public void Login(string email, string password)
        {

            Email = email;
            Password = password;

            Console.Write(" Enter your Email: ");
            Email = Console.ReadLine();

            Console.Write("Enter your Password: ");
            Password = Console.ReadLine();

            Console.WriteLine($"Enter '1' to Deposit \nEnter '2' to Withdraw\nEnter '3' to  Transfer\nEnter '4' to get Account Balance \nEnter '5' to Logout");
            int selection = int.Parse( Console.ReadLine() ); 

            if(selection == 1 ) 
            {
                Deposit();
            }

            if(selection == 2)
            {
                Withdraw();
            }

            if(selection == 3 )
            {
                Transfer();
            }

            if(selection == 4)
            {
                GetStatement();
            }

            if(selection == 5)
            {
                Logout();
            }
        }
       // public AccountOperations AccountOperations { get; set; }
    }

}