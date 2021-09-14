using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Koule : Teleso
    {
        private double polomer;
        public double Polomer
        {
            get => polomer;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Poloměr musí být větší než 0");
                polomer = value;
            }
        }

        public Koule(double r)
        {
            Polomer = r;
        }

        public override double Povrch() { return Math.PI * 4.0 * Polomer * Polomer; }
        public override double Objem() { return Math.PI * 4.0/3.0 * Polomer * Polomer * Polomer; }
    }
}
