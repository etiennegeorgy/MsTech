using System;

namespace _1._2_DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Static Type Animal");
            Console.WriteLine("-------------------------------------------");
            Animal a1 = new Animal();
            Animal a2 = new Dog();
            Animal a3 = new Beagle();
            Animal a4 = new AmericanBeagle();

            a1.WhoAreYou();
            a2.WhoAreYou();
            a3.WhoAreYou();
            a4.WhoAreYou();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Static Type Dog");
            Console.WriteLine("-------------------------------------------");
            Dog d1 = new Dog();
            Dog d2 = new Beagle();
            Dog d3 = new AmericanBeagle();

            d1.WhoAreYou();
            d2.WhoAreYou();
            d3.WhoAreYou();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Static Type Beagle");
            Console.WriteLine("-------------------------------------------");
            Beagle b1 = new Beagle();
            Beagle b2 = new AmericanBeagle();

            b1.WhoAreYou();
            b2.WhoAreYou();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Static Type AmericanBeagle");
            Console.WriteLine("-------------------------------------------");
            AmericanBeagle ab1 = new AmericanBeagle();

            ab1.WhoAreYou();

            Console.ReadKey();
        }
    }

    class Animal
    {
        public virtual void WhoAreYou() { Console.WriteLine("Animal"); }
    }
    class Dog : Animal
    {
        public override void WhoAreYou() { Console.WriteLine("Dog"); }
    }
    class Beagle : Dog
    {
        public new virtual void WhoAreYou() { Console.WriteLine("Beagle"); }
    }
    class AmericanBeagle : Beagle
    {
        public override void WhoAreYou() { Console.WriteLine("AmericanBeagle"); }
    }
}
