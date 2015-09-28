using System;

namespace _1._4_Structs
{
    class ComplexClass
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public ComplexClass(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexClass operator +(ComplexClass c1, ComplexClass c2)
        {
            return new ComplexClass(c1.Real + c1.Real, c1.Imaginary + c1.Imaginary);
        }

        public override string ToString()
        {
            return string.Format("Real: {0} / Imaginary: {1}", Real, Imaginary);
        }
    }
}
