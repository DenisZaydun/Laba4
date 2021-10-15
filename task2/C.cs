using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class C : B
    {
        private string _text = "Hello)";

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }

        public override void PropertiesInfo()
        {
            Debug.WriteLine("Class C:");
            Debug.WriteLine($"Some text: {_text}");
        }
    }
}
