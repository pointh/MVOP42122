using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Koule k = new Koule(2.66);
            Console.WriteLine(k.PomerPovrchKObjemu());
        }
    }
}
