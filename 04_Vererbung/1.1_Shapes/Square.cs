using System;

namespace _1._1_Shapes
{
    // TODO: Von Klasse Polygon ableiten
    class Square : Polygon
    {
        // TODO: Felder implementieren
        private float x1;
        private float y1;
        private float len;
        private const ushort numSides = 4;

        // TODO: Konstruktor implementieren
        public Square(float x1, float y1, float len)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.len = len;
        }

        // TODO: Basis-Members implementieren
        public override ushort NumSides
        {
	        get { return numSides; }
        }

        public override float Area()
        {
 	        return len * len;
        }

        // TODO: X1 / X2 implementieren
        public float X1
        {
            get { return x1; }
            set { x1 = value; }
        }

        public float X2
	    {
		    get { return x1 + len; }
	    }

        // TODO: Y1 / Y2 implementieren
        public float Y1
        {
            get { return y1; }
            set { y1 = value; }
        }

	    public float Y2
	    {
		    get { return y1 + len; }
	    }
	
    }
}
