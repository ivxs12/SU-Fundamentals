using System;
using System.Linq;
using System.Collections.Generic;

namespace Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split();
            List<Student> students = new List<Student>();
            while(input[0] != "end")
            {
                Student student = new Student();
                student.FirstName = input[0];
                student.SecondName = input[1];
                student.Age = input[2];
                student.City = input[3];
                if (IsExisting(students, student))
                {
                    students.Add(student);
                }
                else
                {
                    students.Add(student);
                }
                input = Console.ReadLine().Trim().Split();
            }
            string filter = Console.ReadLine();
            foreach (Student student in students.Where(x => x.City == filter).ToList())
            {
                Console.WriteLine($"{student.FirstName} {student.SecondName} is {student.Age} years old.");
            }
        }
        static bool IsExisting(List<Student> students, Student student)
        {
            foreach (Student a in students)
            {
                if (a.FirstName == student.FirstName && a.SecondName == student.SecondName)
                {
                    students.Remove(a);
                    return true;
                }
            }
            return false;
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Age { get; set; }
        public string City { get; set; }
    }
}
