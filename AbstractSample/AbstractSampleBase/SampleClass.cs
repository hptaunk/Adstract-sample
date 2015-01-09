using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractSampleBase
{

    public class SampleClass : Abstr
    {
        public void Display(string name)
        {
            Console.WriteLine(PrintName(name));
        }
    }
}
