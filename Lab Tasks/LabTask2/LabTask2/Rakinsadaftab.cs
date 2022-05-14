using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask2
{
    class Rakinsadaftab
    {
        // Access Modifier
        public string name;
        protected string id;
        private float cgpa;
        private string semester;
        protected string program;
        public string university;

        // Empty Constructor
        public Rakinsadaftab()
        {
            Console.WriteLine("                                -----------------------------------------------------------");
            Console.WriteLine("                                |                  Hi, I am empty constructor             |");
            Console.WriteLine("                                -----------------------------------------------------------");
            Console.WriteLine("");
        }

        // Parameterized Constructor
        public Rakinsadaftab(string name, string id, float cgpa, string semester, string program, string university)
        {
            Console.WriteLine("");
            Console.WriteLine("                                -----------------------------------------------------------");
            Console.WriteLine("                                |              Hi, I am parameterized constructor         |");
            Console.WriteLine("                                -----------------------------------------------------------");
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
            this.semester = semester;
            this.program = program;
            this.university = university;
        }

        // Copy Constructor
        public Rakinsadaftab(Rakinsadaftab aftab)
        {
            Console.WriteLine("");
            Console.WriteLine("                                -----------------------------------------------------------");
            Console.WriteLine("                                | You copied me from r2, that's why I am copy constructor |");
            Console.WriteLine("                                -----------------------------------------------------------");
            name = aftab.name;
            id = aftab.id;
            cgpa = aftab.cgpa;
            semester = aftab.semester;
            program = aftab.program;
            university = aftab.university;
        }

        // Static Constructor
        static Rakinsadaftab()
        {
            Console.WriteLine("                                -----------------------------------------------------------");
            Console.WriteLine("                                |                  Hi, I am static constructor            |");
            Console.WriteLine("                                -----------------------------------------------------------");
        }

        public void setName(string name) //set method
        {
            this.name = name;
        }
        public string getName() //get method
        {
            return name;
        }

        public void setId(string id) //set method
        {
            this.id = id;
        }
        public string getId() //get method
        {
            return id;
        }

        public void setCGPA(float cgpa) //set method
        {
            this.cgpa = cgpa;
        }
        public float getCGPA() //get method
        {
            return cgpa;
        }

        public void setSemester(string semester) //set method
        {
            this.semester = semester;
        }
        public string getSemester() //get method
        {
            return semester;
        }

        public void setProgram(string program) //set method
        {
            this.program = program;
        }
        public string getProgram() //get method
        {
            return program;
        }

        public void setUniversity(string university) //set method
        {
            this.university = university;
        }
        public string getUniversity() //get method
        {
            return university;
        }

        // Display Function
        public void Display()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Name            : " + name);
            Console.WriteLine("ID              : " + id);
            Console.WriteLine("CGPA            : " + cgpa);
            Console.WriteLine("Semester no     : " + semester);
            Console.WriteLine("Program name    : " + program);
            Console.WriteLine("University name : " + university);
            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}
