using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split();
            List<Person> persons = new List<Person>();
            while (input[0] != "End")
            {
                Person person = new Person(input[0], input[1], Convert.ToInt32(input[2]));
                persons.Add(person);
                input = Console.ReadLine().Trim().Split();
            }
            foreach (Person person in persons.OrderBy(x => x.Age).ToList())
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
        }
    }
}
