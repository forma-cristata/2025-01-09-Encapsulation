using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class Student : Person
    {
        private int studentID { get; } = 0;
        private string grade { get; set; }
        private List<string> courses { get; set; } = [];
        public Student(int studentID, string grade, List<string> courses, string firstName, string lastName, int age, char gender) : base(firstName, lastName, age, gender)
        {
            this.studentID = studentID;
            this.grade = grade;
            this.courses = courses;
        }
        public void PrintStudentAndGrade()
        {
            Console.WriteLine($"{this.firstName} {this.lastName} is in their {this.grade} year of schooling.");
        }
    }
}
