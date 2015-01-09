using AbstractSampleBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractSample1
{
    public class Class1 : Abstr
    {
        public override string PrintName(string name)
        {
            return "Overriding Your name is : " + name;
        }
        public void  Display(string name)
        {
            Console.WriteLine(PrintName(name));
        }
    }
}
