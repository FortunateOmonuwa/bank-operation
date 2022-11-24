using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOperation
{
    public class AccountDetails : CustomerDetails
    {
        
        public string AccountNumber { get; set; }
        public string TransactionPin { get; set; }
        public decimal AccountBalance { get; set; }
        public List<CustomerDetails> UserDetails { get; set; }
    }
}
