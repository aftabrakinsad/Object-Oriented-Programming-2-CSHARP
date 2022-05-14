using System;

namespace LabTask3
{
    class Program
    {
        //Pass by VALUE
        public static void addition(int a)
        {
            a = a + 991;
            Console.WriteLine("After addition (pass by value)          : " + a);
            Console.WriteLine("");
        }

        //Pass by Reference
        public static void multiplication(ref int a)
        {
            a = a * 991;
            Console.WriteLine("After multiplication (pass by reference): " + a);
            Console.WriteLine("");
        }

        //Out Parameter
        public static void outmultiply(out int a)
        {
            a = 991;
            a = a * 1;
            Console.WriteLine("After multiplication (out parameter)    : " + a);
            Console.WriteLine("");
        }
        //params
        public static void displayparams(params int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("My id (using params)                    : " + a[i]);
                Console.WriteLine("");
            }
        }
        //Named perameter
        public static void disnamed(int x1, double x2)
        {
            Console.WriteLine("After using named perameter             : " + (x2 / x1));
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            int a = 991;
            int x = 2041;
            double y = 9911.0;
            Console.WriteLine("Before passing                          : " + a);
            Console.WriteLine("");

            addition(a);
            multiplication(ref a);

            Console.WriteLine("After passing                           : " + a);
            Console.WriteLine("");

            outmultiply(out a);
            displayparams(20419911);
            disnamed(x2: y, x1: x);

            //---------------------------------------------Jagged array---------------------------------------------
            char[][] array = new char[3][];

                                  // 0    1    2    3    4
            array[0] = new char[] { 'R', 'a', 'k', 'i', 'b' };
            array[1] = new char[] { 'S', 'a', 'd' };
            array[2] = new char[] { 'A', 'f', 't', 'a', 'v' };

            array[0][4] = 'n';
            array[2][4] = 'b';

            Console.WriteLine("Printing my name using Jagged array: ");
            for (int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine("array[" + i + "] [" + j + "]: " + array[i][j]);
                }
            }

            Console.ReadKey();
        }
    }
}
