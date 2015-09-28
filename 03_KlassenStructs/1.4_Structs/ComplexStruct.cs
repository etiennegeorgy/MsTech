using System;

namespace _1._4_Structs
{
    struct ComplexStruct
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public ComplexStruct(int real, int imaginary) : this()
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexStruct operator +(ComplexStruct c1, ComplexStruct c2)
        {
            return new ComplexStruct(c1.Real + c1.Real, c1.Imaginary + c1.Imaginary);
        }

        public override string ToString()
        {
            return string.Format("Real: {0} / Imaginary: {1}", Real, Imaginary);
        }
    }
}
