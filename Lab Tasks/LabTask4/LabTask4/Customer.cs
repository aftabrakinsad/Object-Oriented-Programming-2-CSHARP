using System;

namespace LabTask4
{
    class Customer : Person
    {
        private Account acc;

        public void setAcc(Account acc)
        {
            this.acc = acc;
        }
        public Account getAcc()
        {
            return acc;
        }

        public Customer()
        {
            Console.WriteLine("------------------ Empty constructor for Customer --------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public Customer(string name, string dob, Account acc) : base(name, dob)
        {
            Console.WriteLine("------------------ Parameterized constructor for Customer ------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            this.acc = acc;
        }

        public void discus1()
        {
            Console.WriteLine("Information of Customer - 1");
            Console.WriteLine("");
        }

        public void discus2()
        {
            Console.WriteLine("Information of Customer - 2");
            Console.WriteLine("");
        }
    }
}
