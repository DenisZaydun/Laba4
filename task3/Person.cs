using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Person
    {
        private string _name;
        private string _surname;
        private int _age;

        public Person()
        {
            _name = "Denys";
            _surname = "Zaidun";
            _age = 18;
        }

        public virtual void GetInfo()
        {
            Debug.WriteLine($"Name: {_name}");
            Debug.WriteLine($"Surname: {_surname}");
            Debug.WriteLine($"Age: {_age}");
        }
    }
}
