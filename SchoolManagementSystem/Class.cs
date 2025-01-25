using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class Class
    {
        private string name { get; set; }
        private List<Student> students { get; set; } = [];
        private Faculty faculty { get; set; }
        public Class(string name, List<Student> students, Faculty faculty)
        {
            this.name = name;
            this.students = students;
            this.faculty = faculty;
        }
        public void Meets()
        {
            Console.WriteLine($"{this.students.Count} students are here!");
        }
    }
}
