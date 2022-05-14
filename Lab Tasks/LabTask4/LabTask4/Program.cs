using System;

namespace LabTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(76161689, 55000.0, "Employee");
            Account a2 = new Account(78464946, 85000.0, "Employee");
            Account a3 = new Account(65516156, 100000.0, "Customer");
            Account a4 = new Account(21861648, 700000.0, "Customer");

            Employee e1 = new Employee();
            e1.setName("Rakin Sad Aftab");
            e1.setDateofBirth("October 16, 1999");
            e1.disemp1();
            

            Console.WriteLine("Name          : " + e1.getName());
            Console.WriteLine("Date Of Birth : " + e1.getDateofBirth());
            a1.displayAccountDetails();

            Employee e2 = new Employee("Albin Zain Aftab", "10th July 2005", a2);
            e2.disemp2();

            Console.WriteLine("Name          : " + e2.getName());
            Console.WriteLine("Date Of Birth : " + e2.getDateofBirth());
            a2.displayAccountDetails();

            Customer c1 = new Customer();
            c1.setName("Fatema Aftab");
            c1.setDateofBirth("9th December, 2002");
            c1.discus1();

            Console.WriteLine("Name          : " + c1.getName());
            Console.WriteLine("Date Of Birth : " + c1.getDateofBirth());
            a3.displayAccountDetails();

            Customer c2 = new Customer("Raiyan Shams Aftab", "16th September, 2006", a4);
            c2.discus2();

            Console.WriteLine("Name          : " + c2.getName());
            Console.WriteLine("Date Of Birth : " + c2.getDateofBirth());
            a4.displayAccountDetails();

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");

            Console.ReadKey();
        }
    }
}
