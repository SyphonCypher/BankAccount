using System;

namespace BankAccount
{
    public class Client
    {
        public string LName { get; set; }
        public string FName { get; set; }
        public string AccountNum { get; set; }
        public double AcctBal { get; set; }

        public Client()
        {

        }

        public Client(double acctBal)
        {
            this.AcctBal = acctBal;
        }

        public string BlankString(string v1, string v2, string v3)
        {
            return " ";
        }

        public string Menu(string fName, string lName, string accountNum)
        {
        
            //string response = $"Welcome {fName} {lName}. Your account number is {accountNum}.";
            //return response;
            FName = fName;
            LName = lName;
            AccountNum = accountNum;
            string response = "Welcome " + FName + " " + LName + ". " + "Your account number is " + AccountNum + ".";
            Console.WriteLine("Please choose a selection.");
            Console.WriteLine("1. View Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                return response;
            }
            else if (input == 2)
            {
                Console.WriteLine("Please choose a selection.");
                Console.WriteLine("a. Checking Account.");
                Console.WriteLine("b. Savings Account.");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "a")
                {
                    CheckingAccount account = new CheckingAccount();
                    Console.WriteLine("Your checking account balance is: $" + account.GetBalance());

                }
            }
            return response;
        }
    }
}