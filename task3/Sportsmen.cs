using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Sportsmen : Person
    {
        private string _nameOfSport;
        private int _yearInSport;

        public Sportsmen()
        {
            _nameOfSport = "golf";
            _yearInSport = 17;
        }

        public override void GetInfo()
        {
            Debug.WriteLine("\tAs a sportsman");
            base.GetInfo();
            Debug.WriteLine($"Sport: {_nameOfSport}");
            Debug.WriteLine($"Year in sport: {_yearInSport}");
        }
    }
}
