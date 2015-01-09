using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractSampleBase
{
    public abstract class Abstr
    {
        public virtual string PrintName(string name)
        {
            return "Your name is : " + name;
        }
    }
}
