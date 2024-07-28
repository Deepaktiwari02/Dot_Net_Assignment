using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        public int CompareTo(Person other)
        {
            if (other == null) return 0;
            if (this.Age > other.Age) return 1;
            if (this.Age < other.Age) return -1;
            else return 0;
        }

        public static void Main(string[] args)
        {
            Person[] p = new Person[3];
            p[0] = new Person("Shivam", 23);
            p[1] = new Person("Sahil", 14);
            p[2] = new Person("Deepak", 25);

            Console.WriteLine("Before sorting:");
            foreach (var person in p)
            {
                person.Show();
            }

            Array.Sort(p);

            Console.WriteLine("\nAfter sorting:");
            foreach (var person in p)
            {
                person.Show();
            }
            Console.ReadKey();
        }
    }
}
