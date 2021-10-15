using System;
using System.Diagnostics;

namespace task2
{
    class D : B
    {
        public DateTime Time;

        public D()
        {
            Time = DateTime.Now;
        }

        public override void PropertiesInfo()
        {
            Debug.WriteLine("");
            Debug.WriteLine("Class D:");
            Debug.WriteLine($"Data time: {Time}");
        }
    }
}
