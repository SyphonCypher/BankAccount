namespace BankAccount
{
    public class Savings: Account
    {
        public double MinBal { get; set; }

        public Savings()
        {

        }

        public void GetMinBal(double value)
        {
            this.MinBal = value;
        }

        public Savings(double value)
        {
            this.AcctBal = value;
        }

    }
}