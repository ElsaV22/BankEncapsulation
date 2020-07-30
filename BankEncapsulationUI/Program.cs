using System;
using System.Globalization;
using System.Net;

namespace BankEncapsulationUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation Practice
            BankAccount account = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");
            var amountToDeposit = double.Parse(Console.ReadLine());
            account.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your balance is now account {account.GetBalance()}");

            //Properties Practice
            var customerInfo = new PersonalInformation();
            Console.WriteLine("What is your phone number?");
            var phoneNumber = Console.ReadLine();
            customerInfo.NumberFormatted = phoneNumber;

            //Console.WriteLine(customerInfo.NumberFormatted);
            customerInfo.NumberFormatted = Console.ReadLine();
            Console.WriteLine($"Your new phone number is {customerInfo.NumberFormatted}");

          ////requires 10 numbers
          //  var customerInfo = new PersonalInformation();
          //  do
          //  {
          //      Console.WriteLine("What is your phone number?");
          //      var phoneNumber = Console.ReadLine();
          //      customerInfo.NumberFormatted = phoneNumber;
          //  }
          //  while (number.Length != 10 || !long.TryParse(number, out result));
        }
    }
}
