using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class Faculty : Person
    {
        private int employeeID { get; } = 0;
        private List<string> courses { get; set; } = [];
        public Faculty(int employeeID, List<string> courses, string firstName, string lastName, int age, char gender) : base(firstName, lastName, age, gender)
        {
            this.employeeID = employeeID++;
            this.courses = courses;
        }
        public void Teaches()
        {
            Console.Write($"{this.firstName} {this.lastName} teaches ");
            for (int i = 0; i < this.courses.Count; i++)
            {
                if (i == this.courses.Count - 1)
                {
                    Console.WriteLine($"and {this.courses[i]}.");
                    continue;
                }
                Console.Write($"{this.courses[i]}, ");
            }
        }
    }
}
