using System;

namespace LabTask4
{
    class Person
    {
        private string name;
        protected string dob;

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }

        public void setDateofBirth(string dob)
        {
            this.dob = dob;
        }
        public string getDateofBirth()
        {
            return dob;
        }

        public Person()
        {
            Console.WriteLine("------------------ Empty constructor for Person   --------------------------");
        }

        public Person(string name, string dob)
        {
            Console.WriteLine("------------------ Parameterized constructor for Person   ------------------");
            this.name = name;
            this.dob = dob;
        }
    }
}
