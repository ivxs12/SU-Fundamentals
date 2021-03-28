using System;
using System.Collections.Generic;
using System.Linq;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>(n);

            for (int i = 0; i < n; i++)
            {
                string[] studentInfo = Console.ReadLine().Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Student student = new Student(studentInfo[0], studentInfo[1], Convert.ToDouble(studentInfo[2]));
                students.Add(student);
            }
            students = students.OrderBy(x => x.Grade).Reverse().ToList();
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
    }
}
