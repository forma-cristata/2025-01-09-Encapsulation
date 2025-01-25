using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public abstract class Person
    {
        protected string? firstName { get; set; }
        protected string? lastName { get; set; }
        protected int age { get; set; }
        protected char gender { get; set; }
        public Person(String firstName, String lastName, int age, char gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
        }
    }
}
