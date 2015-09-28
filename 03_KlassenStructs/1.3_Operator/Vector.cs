﻿using System;

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
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }
        // TODO: Operator "-" implementieren
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y);
        }
        // TODO: Operator "==" implementieren
        public static bool operator ==(Vector v1, Vector v2)
        {
            return ((v1.X == v2.X) && (v1.Y == v2.Y));
        }
        // TODO: Operator "!=" implementieren
        public static bool operator !=(Vector v1, Vector v2)
        {
            return (!(v1 == v2));
        }

        public override string ToString()
        {
            return string.Format("X: {0} / Y: {1}", X, Y);
        }
    }
}
