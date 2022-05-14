using System;

namespace LabTask4
{
    class Account
    {
        private int accountID;
        private double amount;
        protected string accType;

        public Account(int accountID, double amount, string accType)
        {
            this.accountID = accountID;
            this.amount = amount;
            this.accType = accType;
        }

        public void displayAccountDetails()
        {
            Console.WriteLine("Account ID    : " + accountID);
            Console.WriteLine("Amount        : " + amount);
            Console.WriteLine("Account Type  : " + accType);
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
