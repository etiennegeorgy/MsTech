using System;
using System.Collections.Generic;

namespace _1._3_DynamicBinding
{
    class GraphicObject
    {
        protected string name;

        protected GraphicObject(string name)
        {
            this.name = name;
        }

        public virtual void Draw()
        {
            Console.WriteLine("GraphicObject: {0}", name);
        }

        public void WhoAreYou()
        {
            Console.WriteLine("GraphicObject: {0}", name);
        }
    }

    class Kreis : GraphicObject
    {
        public Kreis(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Kreis: {0}", name);
        }

        public new void WhoAreYou()
        {
            Console.WriteLine("Kreis: {0}", name);
        }
    }
    class Rechteck : GraphicObject
    {
        public Rechteck(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Rechteck: {0}", name);
        }

        public new void WhoAreYou()
        {
            Console.WriteLine("Rechteck: {0}", name);
        }
    }

    class Compound : GraphicObject
    {
        List<GraphicObject> objList = new List<GraphicObject>();

        public Compound(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Compound: {0}", name);
            foreach (GraphicObject g in objList)
            {
                g.Draw();
            }
            Console.WriteLine("End Compound: {0}", name);
        }

        public new void WhoAreYou()
        {
            Console.WriteLine("Compound: {0}", name);
            foreach (GraphicObject g in objList)
            {
                g.WhoAreYou();
            }
            Console.WriteLine("End Compound: {0}", name);
        }

        public void Add(GraphicObject g)
        {
            objList.Add(g);
        }
    }
}
