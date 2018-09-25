using System;

namespace BankAccount
{
    public class Client
    {
        private int v;

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
            //string response = "Welcome " + fName + " " + lName +". " + "Your account number is " + accountNum + ".";
            //return response;
            string response = $"Welcome {fName} {lName}. Your account number is {accountNum}.";
            return response;
        }
    }
}