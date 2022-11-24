using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOperation
{
    public class WelcomeMenu : AccountType
    {
        public void Menu() 
        {
            Console.WriteLine("Welcome To Jelosimi Bank\n");
            Thread.Sleep(2000);

            //string[] selection = new string[1] { $"{ExistingCustomer}, {NewCustomer}" };
            //string customerSelection = selection[selection.Length - 1];
            
            Console.WriteLine($"Select 0 if you already have an account\n\nSelect 1 to create an account\n");
             int customerSelection = int.Parse(Console.ReadLine());
            
            if (customerSelection == 0 ) 
            {
                ExistingCustomer();
            }
            if (customerSelection == 1)
            {
                NewCustomer();
            }
            
        }
        public void ExistingCustomer()
        {
                Login(Email, Password);
        
        }

        public void NewCustomer()
        {
            CreateAccount();

        }

    }
}
