using System;

namespace LabTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displaying using the empty constructor.
            Rakinsadaftab r1 = new Rakinsadaftab();
            r1.setName("Aftab Rakin Sad");
            r1.setId("20-41991-1");
            r1.setCGPA(3.72F);
            r1.setSemester("6");
            r1.setProgram("Computer Science Engineering");
            r1.setUniversity("American International University Bangladesh");
            r1.Display();


            // Displaying using the parameterized constructor. 
            Rakinsadaftab r2 = new Rakinsadaftab("Rakin Sad Aftab", "20-41991-1", 3.72F, "6", "Computer Science Engineering", "American International University Bangladesh");
            r2.Display();


            // Displaying using the copy constructor.
            Rakinsadaftab r3 = new Rakinsadaftab(r2);
            r3.Display();

            Console.ReadKey();
        }
    }
}