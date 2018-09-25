using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccount;

namespace Account.Tests
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



    }
}
