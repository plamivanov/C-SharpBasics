using System;

namespace _01HumanStudenAndWorker
{
    public class Student:Human
    {
        private int facultyNumber;

        public Student(string firstName,string lastName,int facultyNumber):base(firstName,lastName)
        {
            this.FacultyNumber = facultyNumber;   
        }
        public int FacultyNumber { get; set; }

        public override string ToString()
        {
            return base.ToString()+" "+this.FacultyNumber;
        }
    }
}
