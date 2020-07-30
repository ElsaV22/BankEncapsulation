using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationUI
{
    public class BankAccount
    {
        public BankAccount()
        {

        }
        private double balance = 0;

        //Define a method named Deposit that will accept
        //a double and store that value in the balance field

        //Encapsulation
        public void Deposit(double amount)
        {
            balance = amount;
        }

        //Define a meth named GetBalance that will the return the amount stored in the balance field
        public  double GetBalance()
        {
            return balance;
        }


        //public double Balance
        //{
        //    get
        //    {
        //        return balance;
        //    }
        //    set
        //    {
        //        balance = value;
        //    }
        //}



    }
}
