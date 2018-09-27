using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            CheckingAccount checking = new CheckingAccount();
            Savings savings = new Savings();

            checking.AcctNum = 02468;
            checking.AcctType = "checking";
            checking.AcctBal = 1000.00;

            savings.AcctNum = 02468;
            savings.AcctType = "checking";
            savings.AcctBal = 1000.00;
        }
    }
}
