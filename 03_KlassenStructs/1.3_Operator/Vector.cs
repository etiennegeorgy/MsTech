using System;

namespace _1._3_Operator
{
    class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        // TODO: Operator "+" implementieren

        // TODO: Operator "-" implementieren

        // TODO: Operator "==" implementieren

        // TODO: Operator "!=" implementieren

        public override string ToString()
        {
            return string.Format("X: {0} / Y: {1}", X, Y);
        }
    }
}
