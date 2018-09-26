namespace BankAccount
{
    internal class CheckingAccount
    {
        public double AcctBal { get; set; }

        public CheckingAccount(double value)
        {
            this.AcctBal = value;
        }

        public double GetDeposit(double value)
        {
            AcctBal = AcctBal + value;
            return AcctBal;
        }

        public double GetWithdraw(double value)
        {
            AcctBal = AcctBal - value;
            return AcctBal;
        }
    }
}