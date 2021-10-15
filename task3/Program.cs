using System;
using System.Diagnostics;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new[]
            {
                new Person(),
                new Student(),
                new Employee(),
                new Sportsmen()
            };

            foreach (var classes in persons)
            {
                classes.GetInfo();
                Debug.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
