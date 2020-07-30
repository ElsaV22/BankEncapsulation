using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationUI
{
    class CheckingAccount:BankAccount
    {
        public int AccountNumber { get; set; }
        public int RoutingNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
