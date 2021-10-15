using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Student : Person
    {
        private string _universityName;
        private string _faculty;
        private int _yearOfStudy;
        private int _group;

        public Student()
        {
            _universityName = "KNUTE";
            _faculty = "FIT";
            _yearOfStudy = 2;
            _group = 3;
        }

        public override void GetInfo()
        {
            Debug.WriteLine("\tAs a student");
            base.GetInfo();
            Debug.WriteLine($"University Name: {_universityName}");
            Debug.WriteLine($"Faculty: {_faculty}");
            Debug.WriteLine($"Year of study: {_yearOfStudy}");
            Debug.WriteLine($"Group: {_group}");
        }
    }
}
