using System;

namespace SingletonPattern
{
    public class ChocolateBoiler
    {
        public static ChocolateBoiler Instance { get; } = new ChocolateBoiler();

        public bool Empty { get; private set; }
        public bool Boiled { get; private set; }

        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        public void Fill()
        {
            if (Empty)
            {
                Empty = false;
                Boiled = false;
                Console.WriteLine("filling the boiler with a milk/chocolate mixture");
            }
        }

        public void Drain()
        {
            if (!Empty && Boiled)
            {
                Console.WriteLine("draining the boiled milk and chocolate");
                Empty = true;
            }
        }

        public void Boil()
        {
            if (!Empty && !Boiled)
            {
                Console.WriteLine("bringing the contents to a boil");
                Boiled = true;
            }
        }
    }
}