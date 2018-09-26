using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccount;

namespace BankAccount.Tests
{
    [TestFixture]
    class AccountTests
    {
        [Test]
        public void Test_Client_CTR()
        {
            Client client = new Client();
            string response = client.BlankString(" ", " ", " ");
            Assert.That(response, Is.EqualTo(" "));
        }

        [Test]
        public void Test_L_Name_Prop()
        {
            Client client = new Client();
            client.LName = "LName";
            string response = client.LName;
            Assert.That(response, Is.EqualTo("LName"));
        }

        [Test]
        public void Test_F_Name_Prop()
        {
            Client client = new Client();
            client.FName = "FName";
            string response = client.FName;
            Assert.That(response, Is.EqualTo("FName"));
        }

        [Test]
        public void Test_AccountNum_Prop()
        {
            Client client = new Client();
            client.AccountNum = "AccountNum";
            string response = client.AccountNum;
            Assert.That(response, Is.EqualTo("AccountNum"));
        }

        [Test]
        public void Test_Client_Menu_CTR()
        {
            Client client = new Client();
            string response = client.Menu("FName", "LName", "0101010");
            Assert.That(response, Is.EqualTo("Welcome FName LName. Your account number is 0101010."));
        }

        [Test]
        public void Test_Account_CTR()
        {
            Client client = new Client();
            client.AcctBal = 0.0;
            double response = client.AcctBal;
            Assert.That(response, Is.EqualTo(0.0));
        }

        [Test]
        public void Test_Account_CTR_1_Para()
        {
            Client client = new Client(0);
            double response = client.AcctBal;
            Assert.That(response, Is.EqualTo(0.0));
        }

        [Test]
        public void Test_WithDraw_Prop()
        {
            Account account = new Account();
            account.WithDraw = 0.0;
            double response = account.WithDraw;
            Assert.That(response, Is.EqualTo(0.0));
        }

        [Test]
        public void Test_Deposit_Prop()
        {
            Account account = new Account();
            account.Deposit = 0.0;
            double response = account.Deposit;
            Assert.That(response, Is.EqualTo(0.0));
        }

        [Test]
        public void Test_Withdraw_Method()
        {
            Account account = new Account();
            double response = account.Withdraw(0.0);
            Assert.That(response, Is.EqualTo(0.0));
        }

        [Test]
        public void Test_Deposit_Method()
        {
            Account account = new Account();
            double response = account.DePosit(0.0);
            Assert.That(response, Is.EqualTo(0.0));
        }

        [Test]
        public void Test_AccountType_Prop()
        {
            Account account = new Account();
            account.AcctType = " ";
            string response = account.AcctType;
            Assert.That(response, Is.EqualTo(" "));
        }

        [Test]
        public void Test_Checking_Account_CTR()
        {
            CheckingAccount checkingAccount = new CheckingAccount(110);
            double response = checkingAccount.AcctBal;
            Assert.That(response, Is.EqualTo(110));
        }

        [Test]
        public void Test_Checking_Deposit_Method()
        {
            CheckingAccount checkingAccount = new CheckingAccount(5);
            double response = checkingAccount.GetDeposit(110);
            Assert.That(response, Is.EqualTo(115));
        }

        [Test]
        public void Test_Checking_Withdraw_Method()
        {
            CheckingAccount checkingAccount = new CheckingAccount(200);
            double response = checkingAccount.GetWithdraw(100);
            Assert.That(response, Is.EqualTo(100));
        }

        [Test]
        public void Test_Saving_Min_Balance_Prop()
        {
            Savings savings = new Savings(150);
            savings.MinBal = 150;
            double response = savings.MinBal;
            Assert.That(response, Is.EqualTo(150));
        }

        [Test]
        public void Test_Account_Num_Prop()
        {
            Account account = new Account();
            account.AcctNum = 123456;
            int response = account.AcctNum;
            Assert.That(response, Is.EqualTo(123456));
        }

        [Test]
        public void Test_Balance_Prop()
        {
            Account account = new Account();
            account.AcctBal = 5.00;
            double response = account.AcctBal;
            Assert.That(response, Is.EqualTo(5.00));
        }

        [Test]
        public void Test_Get_Balance_Method()
        {
            Account account = new Account();
            account.AcctBal = 100;
            double response = account.GetBalance();
            Assert.That(response, Is.EqualTo(100));

        }

        [Test]
        public void Test_Savings_Deposit_Method()
        {
            Savings savings = new Savings(5);
            double response = savings.GetDeposit(110);
            Assert.That(response, Is.EqualTo(115));
        }

        [Test]
        public void Test_Savings_Withdraw_Method()
        {
            Savings savings = new Savings(115);
            double response = savings.GetWithdraw(110);
            Assert.That(response, Is.EqualTo(5));
        }




    }
}
