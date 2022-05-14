using System;

namespace LabTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit
            int a = 10;
            char b = 'A';

            //Explicit 
            double x = 2.22;
            int y = (int) x; 

            Console.WriteLine("Name: Rakin Sad Aftab");
            Console.WriteLine("ID: 20-41991-1");
            Console.WriteLine();
            Console.Write("Implicit Type Casting: ");
            Console.WriteLine(a + b);
            Console.Write("Explicit Type Casting: ");
            Console.Write(y);
            Console.ReadKey();
        }
    }
}
