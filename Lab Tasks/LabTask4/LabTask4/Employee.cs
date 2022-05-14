using System;

namespace LabTask4
{
    class Employee : Person
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

        public Employee()
        {
            Console.WriteLine("------------------ Empty constructor for Employee --------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public Employee(string name, string dob, Account acc) : base(name, dob)
        {
            Console.WriteLine("------------------ Parameterized constructor for Employee ------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            this.acc = acc;
        }
        public void disemp1()
        {
            Console.WriteLine("Information of Employee - 1");
            Console.WriteLine("");
        }

        public void disemp2()
        {
            Console.WriteLine("Information of Employee - 2");
            Console.WriteLine("");
        }
    }
}
