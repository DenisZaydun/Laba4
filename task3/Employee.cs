using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Employee : Person
    {
        private string _placeOfWork;
        private string _position;

        public Employee()
        {
            _placeOfWork = "Microsoft";
            _position = "Director of c#";
        }

        public override void GetInfo()
        {
            Debug.WriteLine($"\tAs a employee");
            base.GetInfo();
            Debug.WriteLine($"Place of work: {_placeOfWork}");
            Debug.WriteLine($"Position: {_position}");
        }
    }
}
