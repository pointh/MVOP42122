using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public abstract class Teleso
    {
        public abstract double Povrch();
        public abstract double Objem();
        public double PomerPovrchKObjemu() { return Povrch() / Objem(); }
    }
}
